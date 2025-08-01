# Projektanalyse: StatusUpdater

## Projektstruktur

```
StatusUpdater/App.xaml
StatusUpdater/App.xaml.cs
StatusUpdater/Converters/BoolToVisibilityConverter.cs
StatusUpdater/Helpers/Interop.cs
StatusUpdater/Helpers/RelayCommand.cs
StatusUpdater/MainWindow.xaml
StatusUpdater/MainWindow.xaml.cs
StatusUpdater/Resources/Colors.xaml
StatusUpdater/Resources/Styles.xaml
StatusUpdater/Services/IKeepAliveStrategy.cs
StatusUpdater/Services/IdleMonitorService.cs
StatusUpdater/Services/KeepAwakeService.cs
StatusUpdater/Services/KeyboardStrategy_ScanCodeShift.cs
StatusUpdater/Services/KeyboardStrategy_VirtualKey.cs
StatusUpdater/Services/MouseStrategy.cs
StatusUpdater/ViewModels/BaseViewModel.cs
StatusUpdater/ViewModels/DashboardViewModel.cs
StatusUpdater/Views/DashboardView.xaml
StatusUpdater/Views/DashboardView.xaml.cs
StatusUpdater/obj/Debug/net8.0-windows/.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
StatusUpdater/obj/Debug/net8.0-windows/App.g.cs
StatusUpdater/obj/Debug/net8.0-windows/App.g.i.cs
StatusUpdater/obj/Debug/net8.0-windows/GeneratedInternalTypeHelper.g.cs
StatusUpdater/obj/Debug/net8.0-windows/GeneratedInternalTypeHelper.g.i.cs
StatusUpdater/obj/Debug/net8.0-windows/MainWindow.g.cs
StatusUpdater/obj/Debug/net8.0-windows/MainWindow.g.i.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_1lkxkkxn_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_50cifwzq_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_ap324vmc_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_byvbqbxr_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_frgflrdj_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_ivxgvhez_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_l14y4pdl_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_mujp43ro_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_pnqgtmge_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_rellmz12_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_ryjbolq3_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_tr1ydbjv_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_utmb5iws_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Debug/net8.0-windows/Views/DashboardView.g.cs
StatusUpdater/obj/Debug/net8.0-windows/Views/DashboardView.g.i.cs
StatusUpdater/obj/Release/net8.0-windows/.NETCoreApp,Version=v8.0.AssemblyAttributes.cs
StatusUpdater/obj/Release/net8.0-windows/App.g.cs
StatusUpdater/obj/Release/net8.0-windows/App.g.i.cs
StatusUpdater/obj/Release/net8.0-windows/GeneratedInternalTypeHelper.g.cs
StatusUpdater/obj/Release/net8.0-windows/GeneratedInternalTypeHelper.g.i.cs
StatusUpdater/obj/Release/net8.0-windows/MainWindow.g.cs
StatusUpdater/obj/Release/net8.0-windows/MainWindow.g.i.cs
StatusUpdater/obj/Release/net8.0-windows/StatusUpdater.GlobalUsings.g.cs
StatusUpdater/obj/Release/net8.0-windows/StatusUpdater_ek4rjqfe_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Release/net8.0-windows/StatusUpdater_ke14rwqi_wpftmp.GlobalUsings.g.cs
StatusUpdater/obj/Release/net8.0-windows/Views/DashboardView.g.cs
StatusUpdater/obj/Release/net8.0-windows/Views/DashboardView.g.i.cs
```

## App

### `StatusUpdater/App.xaml`

- Ressourcen- oder UI-Definition für die Oberfläche.

### `StatusUpdater/App.xaml.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Einstiegspunkt der Anwendung.

## Converters

### `StatusUpdater/Converters/BoolToVisibilityConverter.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Implementiert einen ValueConverter (z. B. für Bindings in WPF).

## Helpers

### `StatusUpdater/Helpers/Interop.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.

### `StatusUpdater/Helpers/RelayCommand.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Enthält Command-Logik (RelayCommand oder DelegateCommand).
- Methode: `public bool CanExecute(object? parameter) => _can?.Invoke(parameter) ?? true;`
- Methode: `public void Execute(object? parameter) => _exec(parameter);`

## Resources

### `StatusUpdater/Resources/Colors.xaml`

- Ressourcen- oder UI-Definition für die Oberfläche.

### `StatusUpdater/Resources/Styles.xaml`

- Ressourcen- oder UI-Definition für die Oberfläche.

## Services

### `StatusUpdater/Services/IKeepAliveStrategy.cs`

- Enthält ein Interface zur Abstraktion einer Strategie oder Logik.
- Methode: `public interface IKeepAliveStrategy { void Pulse(); }`

### `StatusUpdater/Services/IdleMonitorService.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- MVVM ViewModel mit Property-Changed-Mechanismus.
- Methode: `public void Start() => _timer.Start();`
- Methode: `public void Stop() => _timer.Stop();`
- Methode: `public void Dispose() => _timer.Stop();`

### `StatusUpdater/Services/KeepAwakeService.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void Enable() => SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED);`
- Methode: `public void Refresh() => Enable();`
- Methode: `public void Disable() => SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);`

### `StatusUpdater/Services/KeyboardStrategy_ScanCodeShift.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void Pulse()`

### `StatusUpdater/Services/KeyboardStrategy_VirtualKey.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void Pulse()`

### `StatusUpdater/Services/MouseStrategy.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void Pulse()`

## ViewModels

### `StatusUpdater/ViewModels/BaseViewModel.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- MVVM ViewModel mit Property-Changed-Mechanismus.

### `StatusUpdater/ViewModels/DashboardViewModel.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Implementiert einen ValueConverter (z. B. für Bindings in WPF).
- Methode: `public bool KeepAwakeEnabled { get => _keepAwakeEnabled; set => Set(ref _keepAwakeEnabled, value); }`
- Methode: `public bool IsRunning { get => _isRunning; private set { if (Set(ref _isRunning, value)) { Raise(nameof(CanStart)); Raise(nameof(StartButtonText)); } } }`
- Methode: `public bool CanStart => !IsRunning && IntervalSeconds >= 20;`
- Methode: `public bool IsKeyboard => SelectedMethod == Method.Keyboard;`
- Methode: `public bool IsMouse => SelectedMethod == Method.Mouse;`

## Views

### `StatusUpdater/Views/DashboardView.xaml`

- Ressourcen- oder UI-Definition für die Oberfläche.

### `StatusUpdater/Views/DashboardView.xaml.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.

## Main

### `StatusUpdater/MainWindow.xaml`

- Ressourcen- oder UI-Definition für die Oberfläche.
- Hauptfenster der Anwendung.

### `StatusUpdater/MainWindow.xaml.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Hauptfenster der Anwendung.

### `StatusUpdater/obj/Debug/net8.0-windows/.NETCoreApp,Version=v8.0.AssemblyAttributes.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/App.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Einstiegspunkt der Anwendung.
- Methode: `public void InitializeComponent() {`
- Methode: `public static void Main() {`

### `StatusUpdater/obj/Debug/net8.0-windows/App.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Einstiegspunkt der Anwendung.
- Methode: `public void InitializeComponent() {`
- Methode: `public static void Main() {`

### `StatusUpdater/obj/Debug/net8.0-windows/GeneratedInternalTypeHelper.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.

### `StatusUpdater/obj/Debug/net8.0-windows/GeneratedInternalTypeHelper.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.

### `StatusUpdater/obj/Debug/net8.0-windows/MainWindow.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Hauptfenster der Anwendung.
- Methode: `public void InitializeComponent() {`

### `StatusUpdater/obj/Debug/net8.0-windows/MainWindow.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Hauptfenster der Anwendung.
- Methode: `public void InitializeComponent() {`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_1lkxkkxn_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_50cifwzq_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_ap324vmc_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_byvbqbxr_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_frgflrdj_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_ivxgvhez_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_l14y4pdl_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_mujp43ro_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_pnqgtmge_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_rellmz12_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_ryjbolq3_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_tr1ydbjv_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/StatusUpdater_utmb5iws_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Debug/net8.0-windows/Views/DashboardView.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void InitializeComponent() {`

### `StatusUpdater/obj/Debug/net8.0-windows/Views/DashboardView.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void InitializeComponent() {`

### `StatusUpdater/obj/Release/net8.0-windows/.NETCoreApp,Version=v8.0.AssemblyAttributes.cs`

### `StatusUpdater/obj/Release/net8.0-windows/App.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Einstiegspunkt der Anwendung.
- Methode: `public void InitializeComponent() {`
- Methode: `public static void Main() {`

### `StatusUpdater/obj/Release/net8.0-windows/App.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Einstiegspunkt der Anwendung.
- Methode: `public void InitializeComponent() {`
- Methode: `public static void Main() {`

### `StatusUpdater/obj/Release/net8.0-windows/GeneratedInternalTypeHelper.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.

### `StatusUpdater/obj/Release/net8.0-windows/GeneratedInternalTypeHelper.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.

### `StatusUpdater/obj/Release/net8.0-windows/MainWindow.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Hauptfenster der Anwendung.
- Methode: `public void InitializeComponent() {`

### `StatusUpdater/obj/Release/net8.0-windows/MainWindow.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Hauptfenster der Anwendung.
- Methode: `public void InitializeComponent() {`

### `StatusUpdater/obj/Release/net8.0-windows/StatusUpdater.GlobalUsings.g.cs`

### `StatusUpdater/obj/Release/net8.0-windows/StatusUpdater_ek4rjqfe_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Release/net8.0-windows/StatusUpdater_ke14rwqi_wpftmp.GlobalUsings.g.cs`

### `StatusUpdater/obj/Release/net8.0-windows/Views/DashboardView.g.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void InitializeComponent() {`

### `StatusUpdater/obj/Release/net8.0-windows/Views/DashboardView.g.i.cs`

- Enthält eine Klasse, die eine bestimmte Logik oder Ansicht abbildet.
- Methode: `public void InitializeComponent() {`
