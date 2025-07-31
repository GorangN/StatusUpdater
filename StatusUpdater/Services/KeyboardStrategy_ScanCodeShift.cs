using StatusUpdater.Helpers;
using static StatusUpdater.Helpers.Interop;

namespace StatusUpdater.Services;

/// Sendet LeftShift per ScanCode (0x2A) – sehr zuverlässig für Idle-Reset
public class KeyboardStrategy_ScanCodeShift : IKeepAliveStrategy
{
    public void Pulse()
    {
        const ushort SC_SHIFT = 0x2A;
        var inputs = new INPUT[2];
        inputs[0] = new INPUT { type = INPUT_KEYBOARD, U = new InputUnion { ki = new KEYBDINPUT { wVk = 0, wScan = SC_SHIFT, dwFlags = KEYEVENTF_SCANCODE } } };
        inputs[1] = new INPUT { type = INPUT_KEYBOARD, U = new InputUnion { ki = new KEYBDINPUT { wVk = 0, wScan = SC_SHIFT, dwFlags = KEYEVENTF_SCANCODE | KEYEVENTF_KEYUP } } };
        SendInput((uint)inputs.Length, inputs, INPUT.Size);
    }
}
