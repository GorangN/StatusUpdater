using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using StatusUpdater.Helpers;
using StatusUpdater.Services;

namespace StatusUpdater.ViewModels;

public enum Method { Keyboard, Mouse }

public class DashboardViewModel : BaseViewModel
{
    private readonly KeepAwakeService _keepAwake = new();
    private readonly IdleMonitorService _idleMonitor = new();
    private IKeepAliveStrategy _strategy;

    public ObservableCollection<Method> Methods { get; } = new(new[] { Method.Keyboard, Method.Mouse });

    private Method _selectedMethod = Method.Keyboard;
    public Method SelectedMethod { get => _selectedMethod; set { if (Set(ref _selectedMethod, value)) OnMethodChanged(); } }

    private int _intervalSeconds = 60;               // konservativ fürs erste
    public int IntervalSeconds { get => _intervalSeconds; set { Set(ref _intervalSeconds, value); Raise(nameof(CanStart)); } }

    private int _keyboardVk = 126;                   // F15
    public int KeyboardVk { get => _keyboardVk; set => Set(ref _keyboardVk, value); }

    private int _mousePixels = 2;
    public int MousePixels { get => _mousePixels; set => Set(ref _mousePixels, Math.Clamp(value, 1, 5)); }

    private bool _keepAwakeEnabled = true;
    public bool KeepAwakeEnabled { get => _keepAwakeEnabled; set => Set(ref _keepAwakeEnabled, value); }

    private bool _isRunning;
    public bool IsRunning { get => _isRunning; private set { if (Set(ref _isRunning, value)) { Raise(nameof(CanStart)); Raise(nameof(StartButtonText)); } } }

    public bool CanStart => !IsRunning && IntervalSeconds >= 20;
    public string StartButtonText => IsRunning ? "Running…" : "Start";

    private string _statusText = "Idle";
    public string StatusText { get => _statusText; set => Set(ref _statusText, value); }

    public int IdleSeconds => _idleMonitor.IdleSeconds;

    public bool IsKeyboard => SelectedMethod == Method.Keyboard;
    public bool IsMouse => SelectedMethod == Method.Mouse;

    public RelayCommand StartCommand { get; }
    public RelayCommand StopCommand { get; }

    private CancellationTokenSource? _cts;
    private readonly Random _rnd = new();

    public DashboardViewModel()
    {
        _strategy = new KeyboardStrategy_ScanCodeShift();   // Standard: robust
        _idleMonitor.PropertyChanged += (_, __) => Raise(nameof(IdleSeconds));
        _idleMonitor.Start();

        StartCommand = new RelayCommand(async _ => await StartAsync(), _ => CanStart);
        StopCommand = new RelayCommand(_ => Stop(), _ => IsRunning);
    }

    private void OnMethodChanged()
    {
        Raise(nameof(IsKeyboard)); Raise(nameof(IsMouse));
        _strategy = SelectedMethod == Method.Keyboard
            ? new KeyboardStrategy_VirtualKey((ushort)KeyboardVk)   // falls du VK bevorzugst
            : new MouseStrategy(MousePixels);
    }

    private async Task StartAsync()
    {
        _cts = new CancellationTokenSource();
        IsRunning = true;
        StatusText = "Running…";
        if (KeepAwakeEnabled) _keepAwake.Enable();

        // Immer zusätzlich den robusten Shift-ScanCode senden (am sichersten)
        var robustShift = new KeyboardStrategy_ScanCodeShift();

        try
        {
            while (!_cts.IsCancellationRequested)
            {
                robustShift.Pulse();  // garantiert ScanCode
                _strategy.Pulse();    // zusätzlich gewählte Methode

                var jitter = _rnd.Next(-15, 16);
                var wait = Math.Max(20, IntervalSeconds + jitter);
                await Task.Delay(TimeSpan.FromSeconds(wait), _cts.Token);

                if (KeepAwakeEnabled) _keepAwake.Refresh();
            }
        }
        catch (TaskCanceledException) { }
        finally
        {
            if (KeepAwakeEnabled) _keepAwake.Disable();
            IsRunning = false;
            StatusText = "Stopped";
        }
    }

    private void Stop() => _cts?.Cancel();
}
