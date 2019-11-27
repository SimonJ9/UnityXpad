//cont mapping
public static class XKey
{
    //SharpDX.XInput.GamepadButtonFlags
    public const ushort DPadUp = 1;
    public const ushort DPadDown = 2;
    public const ushort DPadLeft = 4;
    public const ushort DPadRight = 8;
    public const ushort Start = 16;
    public const ushort Back = 32;
    public const ushort LeftThumb = 64;
    public const ushort RightThumb = 128;
    public const ushort LeftShoulder = 256;
    public const ushort RightShoulder = 512;
    public const ushort A = 4096;
    public const ushort B = 8192;
    public const ushort X = 16384;
    public const ushort Y = 32768;

    //axis alias
    public const int LeftThumbX = 131072;
    public const int LeftThumbY = 262144;
    public const int RightThumbX = 524288;
    public const int RightThumbY = 1048576;
    public const int LeftTrigger = 2097152;
    public const int RightTrigger = 4194304;

    //GamepadKeyCode to GamepadButtonFlags
    public static ushort KeyCode2ButtonFlags(short k)
    {
        switch (k)
        {
            case 22528:
                return A;
            case 22529:
                return B;
            case 22530:
                return X;
            case 22531:
                return Y;
            case 22532:
                return RightShoulder;
            case 22533:
                return LeftShoulder;
            case 22544:
                return DPadUp;
            case 22545:
                return DPadDown;
            case 22546:
                return DPadLeft;
            case 22547:
                return DPadRight;
            case 22548:
                return Start;
            case 22549:
                return Back;
            case 22550:
                return LeftThumb;
            case 22551:
                return RightThumb;
            default:
                return 0;
        }
        /* axis
        LeftTrigger = 22534,
        RightTrigger = 22535,

        LeftThumbUp = 22560,
        LeftThumbDown = 22561,
        LeftThumbRight = 22562,
        LeftThumbLeft = 22563,
        RightThumbUpLeft = 22564,
        LeftThumbUpright = 22565,
        LeftThumbDownright = 22566,
        RightThumbDownLeft = 22567,
        RightThumbUp = 22576,
        RightThumbDown = 22577,
        RightThumbRight = 22578,
        RightThumbLeft = 22579,
        RightThumbUpleft = 22580,
        RightThumbUpRight = 22581,
        RightThumbDownRight = 22582,
        RightThumbDownleft = 22583
        */
    }
}