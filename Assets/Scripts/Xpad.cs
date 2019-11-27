using SharpDX;
using SharpDX.XInput;

public static class Xpad
{
    private static Controller[] Gamepads = {
        new Controller(UserIndex.One),
        new Controller(UserIndex.Two),
        new Controller(UserIndex.Three),
        new Controller(UserIndex.Four) };

    public static bool HasGamepad(int id=0)
    {
        if(id == 0)
        {
            foreach (Controller c in Gamepads)
            {
                if (c.IsConnected) return true;
            }
        }
        if(id > 0 && id <= 4)
        {
            return Gamepads[id - 1].IsConnected;
        }
        return false;
    }

    public static int NumConnectedGamepads()
    {
        int n = 0;
        foreach (Controller c in Gamepads)
        {
            if(c.IsConnected)
            {
                n++;
            }
        }
        return n;
    }

    public static bool GetKey(ushort k, int id=0)
    {
        Controller g;
        if (id == 0) g = GetFirstPad();
        else if (id > 0 && id <= 4) g = Gamepads[id-1];
        else return false;
        if (!g.IsConnected) return false;

        ushort b = (ushort)g.GetState().Gamepad.Buttons;
        return (b & k) == k;
    }

    public static bool GetKeyDown(ushort k, int id=0)
    {
        Controller g;
        if (id == 0) g = GetFirstPad();
        else if (id > 0 && id <= 4) g = Gamepads[id - 1];
        else return false;
        if (!g.IsConnected) return false;

        Keystroke s;
        Result r = g.GetKeystroke(DeviceQueryType.Gamepad, out s);

        return XKey.KeyCode2ButtonFlags((short)s.VirtualKey) == k && s.Flags == KeyStrokeFlags.KeyDown;
    }

    public static bool GetKeyUp(ushort k, int id=0)
    {
        Controller g;
        if (id == 0) g = GetFirstPad();
        else if (id > 0 && id <= 4) g = Gamepads[id - 1];
        else return false;
        if (!g.IsConnected) return false;

        Keystroke s;
        Result r = g.GetKeystroke(DeviceQueryType.Gamepad, out s);

        return XKey.KeyCode2ButtonFlags((short)s.VirtualKey) == k && s.Flags == KeyStrokeFlags.KeyUp;
    }

    public static float GetAxis(int a, int id=0)
    {
        Controller g;
        if (id == 0) g = GetFirstPad();
        else if (id > 0 && id <= 4) g = Gamepads[id - 1];
        else return 0;
        if (!g.IsConnected) return 0;

        float axisRaw;
        switch (a)
        {
            case XKey.LeftThumbX:
                axisRaw = g.GetState().Gamepad.LeftThumbX;
                axisRaw = axisRaw > 0 ? axisRaw / short.MaxValue : axisRaw / (short.MaxValue + 1);
                break;
            case XKey.LeftThumbY:
                axisRaw = g.GetState().Gamepad.LeftThumbY;
                axisRaw = axisRaw > 0 ? axisRaw / short.MaxValue : axisRaw / (short.MaxValue + 1);
                break;
            case XKey.RightThumbX:
                axisRaw = g.GetState().Gamepad.RightThumbX;
                axisRaw = axisRaw > 0 ? axisRaw / short.MaxValue : axisRaw / (short.MaxValue + 1);
                break;
            case XKey.RightThumbY:
                axisRaw = g.GetState().Gamepad.RightThumbY;
                axisRaw = axisRaw > 0 ? axisRaw / short.MaxValue : axisRaw / (short.MaxValue + 1);
                break;
            case XKey.LeftTrigger:
                axisRaw = g.GetState().Gamepad.LeftTrigger;
                axisRaw = axisRaw > 0 ? axisRaw / byte.MaxValue : axisRaw / (byte.MaxValue + 1);
                break;
            case XKey.RightTrigger:
                axisRaw = g.GetState().Gamepad.RightTrigger;
                axisRaw = axisRaw > 0 ? axisRaw / byte.MaxValue : axisRaw / (byte.MaxValue + 1);
                break;
            default:
                return 0;
        }
        return axisRaw;
    }

    public static int GetAxisRaw(int a, int id=0)
    {
        Controller g;
        if (id == 0) g = GetFirstPad();
        else if (id > 0 && id <= 4) g = Gamepads[id - 1];
        else return 0;
        if (!g.IsConnected) return 0;

        float axisRaw;
        switch (a)
        {
            case XKey.LeftThumbX:
                axisRaw = g.GetState().Gamepad.LeftThumbX;
                break;
            case XKey.LeftThumbY:
                axisRaw = g.GetState().Gamepad.LeftThumbY;
                break;
            case XKey.RightThumbX:
                axisRaw = g.GetState().Gamepad.RightThumbX;
                break;
            case XKey.RightThumbY:
                axisRaw = g.GetState().Gamepad.RightThumbY;
                break;
            case XKey.LeftTrigger:
                axisRaw = g.GetState().Gamepad.LeftTrigger;
                break;
            case XKey.RightTrigger:
                axisRaw = g.GetState().Gamepad.RightTrigger;
                break;
            default:
                return 0;
        }
        if (axisRaw > 0) return 1;
        if (axisRaw < 0) return -1;
        return 0;
    }

    public static Controller[] GetAllConnectedGamepads()
    {
        Controller[] g = new Controller[NumConnectedGamepads()];
        int i = 0;
        foreach (Controller c in Gamepads)
        {
            if (c.IsConnected)
            {
                g[i] = c;
                i++;
            }
        }
        return g;
    }

    private static Controller GetFirstPad()
    {
        foreach (Controller c in Gamepads)
        {
            if (c.IsConnected) return c;
        }
        return null;
    }
}