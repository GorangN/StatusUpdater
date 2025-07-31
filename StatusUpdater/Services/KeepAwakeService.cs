using static StatusUpdater.Helpers.Interop;

namespace StatusUpdater.Services;
public class KeepAwakeService
{
    public void Enable() => SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
    public void Refresh() => Enable();
    public void Disable() => SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
}
