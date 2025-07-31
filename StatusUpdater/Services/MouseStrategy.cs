using StatusUpdater.Helpers;
using static StatusUpdater.Helpers.Interop;

namespace StatusUpdater.Services;
public class MouseStrategy : IKeepAliveStrategy
{
    private readonly int _px;
    public MouseStrategy(int px) { _px = Math.Clamp(px, 1, 5); }

    public void Pulse()
    {
        var inputs = new INPUT[2];
        inputs[0] = new INPUT { type = INPUT_MOUSE, U = new InputUnion { mi = new MOUSEINPUT { dx = _px, dy = 0, dwFlags = MOUSEEVENTF_MOVE } } };
        inputs[1] = new INPUT { type = INPUT_MOUSE, U = new InputUnion { mi = new MOUSEINPUT { dx = -_px, dy = 0, dwFlags = MOUSEEVENTF_MOVE } } };
        SendInput((uint)inputs.Length, inputs, INPUT.Size);

        // Optional: kleines Wheel-Tick zählt oft auch als Aktivität
        //var wheel = new INPUT { type = INPUT_MOUSE, U = new InputUnion { mi = new MOUSEINPUT { mouseData = 1, dwFlags = MOUSEEVENTF_WHEEL } } };
        //SendInput(1, new[] { wheel }, INPUT.Size);
    }
}
