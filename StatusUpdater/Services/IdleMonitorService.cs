using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using static StatusUpdater.Helpers.Interop;

namespace StatusUpdater.Services;

public class IdleMonitorService : INotifyPropertyChanged, IDisposable
{
	private readonly DispatcherTimer _timer;
	private int _idleSeconds;
	public int IdleSeconds
	{
		get => _idleSeconds;
		private set { if (_idleSeconds != value) { _idleSeconds = value; OnPropertyChanged(); } }
	}

	public IdleMonitorService()
	{
		_timer = new DispatcherTimer
		{
			Interval = TimeSpan.FromSeconds(1)
		};
		_timer.Tick += (_, __) => IdleSeconds = GetIdleSeconds();
	}

	public void Start() => _timer.Start();
	public void Stop() => _timer.Stop();

	private static int GetIdleSeconds()
	{
		var lii = new LASTINPUTINFO { cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf<LASTINPUTINFO>() };
		if (!GetLastInputInfo(ref lii)) return -1;
		uint tick = (uint)Environment.TickCount;
		return (int)((tick - lii.dwTime) / 1000);
	}

	public event PropertyChangedEventHandler? PropertyChanged;
	private void OnPropertyChanged([CallerMemberName] string? name = null)
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

	public void Dispose() => _timer.Stop();
}
