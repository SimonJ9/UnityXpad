using UnityEngine;

public class Demo : MonoBehaviour
{
    bool G1A, G1B, G1X, G1Y, G1Dup, G1Ddown, G1Dleft, G1Dright, G1L1, G1L3, G1R1, G1R3, G1Back, G1Start;
    bool G2A, G2B, G2X, G2Y, G2Dup, G2Ddown, G2Dleft, G2Dright, G2L1, G2L3, G2R1, G2R3, G2Back, G2Start;
    bool G3A, G3B, G3X, G3Y, G3Dup, G3Ddown, G3Dleft, G3Dright, G3L1, G3L3, G3R1, G3R3, G3Back, G3Start;
    bool G4A, G4B, G4X, G4Y, G4Dup, G4Ddown, G4Dleft, G4Dright, G4L1, G4L3, G4R1, G4R3, G4Back, G4Start;

    float G1LX, G1LY, G1RX, G1RY, G1LT, G1RT;
    float G2LX, G2LY, G2RX, G2RY, G2LT, G2RT;
    float G3LX, G3LY, G3RX, G3RY, G3LT, G3RT;
    float G4LX, G4LY, G4RX, G4RY, G4LT, G4RT;

    void Update()
    {
        G1A = Xpad.GetKey(XKey.A, 1);
        G1B = Xpad.GetKey(XKey.B, 1);
        G1X = Xpad.GetKey(XKey.X, 1);
        G1Y = Xpad.GetKey(XKey.Y, 1);
        G1Dup = Xpad.GetKey(XKey.DPadUp, 1);
        G1Ddown = Xpad.GetKey(XKey.DPadDown, 1);
        G1Dleft = Xpad.GetKey(XKey.DPadLeft, 1);
        G1Dright = Xpad.GetKey(XKey.DPadRight, 1);
        G1L1 = Xpad.GetKey(XKey.LeftShoulder, 1);
        G1L3 = Xpad.GetKey(XKey.LeftThumb, 1);
        G1R1 = Xpad.GetKey(XKey.RightShoulder, 1);
        G1R3 = Xpad.GetKey(XKey.RightThumb, 1);
        G1LX = Xpad.GetAxis(XKey.LeftThumbX, 1);
        G1LY = Xpad.GetAxis(XKey.LeftThumbY, 1);
        G1RX = Xpad.GetAxis(XKey.RightThumbX, 1);
        G1RY = Xpad.GetAxis(XKey.RightThumbY, 1);
        G1LT = Xpad.GetAxis(XKey.LeftTrigger, 1);
        G1RT = Xpad.GetAxis(XKey.RightTrigger, 1);

        G2A = Xpad.GetKey(XKey.A, 2);
        G2B = Xpad.GetKey(XKey.B, 2);
        G2X = Xpad.GetKey(XKey.X, 2);
        G2Y = Xpad.GetKey(XKey.Y, 2);
        G2Dup = Xpad.GetKey(XKey.DPadUp, 2);
        G2Ddown = Xpad.GetKey(XKey.DPadDown, 2);
        G2Dleft = Xpad.GetKey(XKey.DPadLeft, 2);
        G2Dright = Xpad.GetKey(XKey.DPadRight, 2);
        G2L1 = Xpad.GetKey(XKey.LeftShoulder, 2);
        G2L3 = Xpad.GetKey(XKey.LeftThumb, 2);
        G2R1 = Xpad.GetKey(XKey.RightShoulder, 2);
        G2R3 = Xpad.GetKey(XKey.RightThumb, 2);
        G2LX = Xpad.GetAxis(XKey.LeftThumbX, 2);
        G2LY = Xpad.GetAxis(XKey.LeftThumbY, 2);
        G2RX = Xpad.GetAxis(XKey.RightThumbX, 2);
        G2RY = Xpad.GetAxis(XKey.RightThumbY, 2);
        G2LT = Xpad.GetAxis(XKey.LeftTrigger, 2);
        G2RT = Xpad.GetAxis(XKey.RightTrigger, 2);

        G3A = Xpad.GetKey(XKey.A, 3);
        G3B = Xpad.GetKey(XKey.B, 3);
        G3X = Xpad.GetKey(XKey.X, 3);
        G3Y = Xpad.GetKey(XKey.Y, 3);
        G3Dup = Xpad.GetKey(XKey.DPadUp, 3);
        G3Ddown = Xpad.GetKey(XKey.DPadDown, 3);
        G3Dleft = Xpad.GetKey(XKey.DPadLeft, 3);
        G3Dright = Xpad.GetKey(XKey.DPadRight, 3);
        G3L1 = Xpad.GetKey(XKey.LeftShoulder, 3);
        G3L3 = Xpad.GetKey(XKey.LeftThumb, 3);
        G3R1 = Xpad.GetKey(XKey.RightShoulder, 3);
        G3R3 = Xpad.GetKey(XKey.RightThumb, 3);
        G3LX = Xpad.GetAxis(XKey.LeftThumbX, 3);
        G3LY = Xpad.GetAxis(XKey.LeftThumbY, 3);
        G3RX = Xpad.GetAxis(XKey.RightThumbX, 3);
        G3RY = Xpad.GetAxis(XKey.RightThumbY, 3);
        G3LT = Xpad.GetAxis(XKey.LeftTrigger, 3);
        G3RT = Xpad.GetAxis(XKey.RightTrigger, 3);

        G4A = Xpad.GetKey(XKey.A, 4);
        G4B = Xpad.GetKey(XKey.B, 4);
        G4X = Xpad.GetKey(XKey.X, 4);
        G4Y = Xpad.GetKey(XKey.Y, 4);
        G4Dup = Xpad.GetKey(XKey.DPadUp, 4);
        G4Ddown = Xpad.GetKey(XKey.DPadDown, 4);
        G4Dleft = Xpad.GetKey(XKey.DPadLeft, 4);
        G4Dright = Xpad.GetKey(XKey.DPadRight, 4);
        G4L1 = Xpad.GetKey(XKey.LeftShoulder, 4);
        G4L3 = Xpad.GetKey(XKey.LeftThumb, 4);
        G4R1 = Xpad.GetKey(XKey.RightShoulder, 4);
        G4R3 = Xpad.GetKey(XKey.RightThumb, 4);
        G4LX = Xpad.GetAxis(XKey.LeftThumbX, 4);
        G4LY = Xpad.GetAxis(XKey.LeftThumbY, 4);
        G4RX = Xpad.GetAxis(XKey.RightThumbX, 4);
        G4RY = Xpad.GetAxis(XKey.RightThumbY, 4);
        G4LT = Xpad.GetAxis(XKey.LeftTrigger, 4);
        G4RT = Xpad.GetAxis(XKey.RightTrigger, 4);
    }

    private void OnGUI()
    {
        GUILayout.BeginHorizontal("box");

        GUILayout.BeginVertical("box", GUILayout.Width(200));
        GUILayout.Label("Gamepad 1 A: " + G1A);
        GUILayout.Label("Gamepad 1 B: " + G1B);
        GUILayout.Label("Gamepad 1 X: " + G1X);
        GUILayout.Label("Gamepad 1 Y: " + G1Y);
        GUILayout.Label("Gamepad 1 Up: " + G1Dup);
        GUILayout.Label("Gamepad 1 Down: " + G1Ddown);
        GUILayout.Label("Gamepad 1 Left: " + G1Dleft);
        GUILayout.Label("Gamepad 1 Right: " + G1Dright);
        GUILayout.Label("Gamepad 1 L1: " + G1L1);
        GUILayout.Label("Gamepad 1 R1: " + G1R1);
        GUILayout.Label("Gamepad 1 L3: " + G1L3);
        GUILayout.Label("Gamepad 1 R3: " + G1R3);
        GUILayout.Label("Gamepad 1 Start: " + G1Start);
        GUILayout.Label("Gamepad 1 Back: " + G1Back);
        GUILayout.Label("Gamepad 1 LT: " + G1LT);
        GUILayout.Label("Gamepad 1 RT: " + G1RT);
        GUILayout.Label("Gamepad 1 LX: " + G1LX);
        GUILayout.Label("Gamepad 1 LY: " + G1LY);
        GUILayout.Label("Gamepad 1 RX: " + G1RX);
        GUILayout.Label("Gamepad 1 RY: " + G1RY);
        GUILayout.EndVertical();

        GUILayout.BeginVertical("box", GUILayout.Width(200));
        GUILayout.Label("Gamepad 2 A: " + G2A);
        GUILayout.Label("Gamepad 2 B: " + G2B);
        GUILayout.Label("Gamepad 2 X: " + G2X);
        GUILayout.Label("Gamepad 2 Y: " + G2Y);
        GUILayout.Label("Gamepad 2 Up: " + G2Dup);
        GUILayout.Label("Gamepad 2 Down: " + G2Ddown);
        GUILayout.Label("Gamepad 2 Left: " + G2Dleft);
        GUILayout.Label("Gamepad 2 Right: " + G2Dright);
        GUILayout.Label("Gamepad 2 L1: " + G2L1);
        GUILayout.Label("Gamepad 2 R1: " + G2R1);
        GUILayout.Label("Gamepad 2 L3: " + G2L3);
        GUILayout.Label("Gamepad 2 R3: " + G2R3);
        GUILayout.Label("Gamepad 2 Start: " + G2Start);
        GUILayout.Label("Gamepad 2 Back: " + G2Back);
        GUILayout.Label("Gamepad 2 LT: " + G2LT);
        GUILayout.Label("Gamepad 2 RT: " + G2RT);
        GUILayout.Label("Gamepad 2 LX: " + G2LX);
        GUILayout.Label("Gamepad 2 LY: " + G2LY);
        GUILayout.Label("Gamepad 2 RX: " + G2RX);
        GUILayout.Label("Gamepad 2 RY: " + G2RY);
        GUILayout.EndVertical();

        GUILayout.BeginVertical("box", GUILayout.Width(200));
        GUILayout.Label("Gamepad 3 A: " + G3A);
        GUILayout.Label("Gamepad 3 B: " + G3B);
        GUILayout.Label("Gamepad 3 X: " + G3X);
        GUILayout.Label("Gamepad 3 Y: " + G3Y);
        GUILayout.Label("Gamepad 3 Up: " + G3Dup);
        GUILayout.Label("Gamepad 3 Down: " + G3Ddown);
        GUILayout.Label("Gamepad 3 Left: " + G3Dleft);
        GUILayout.Label("Gamepad 3 Right: " + G3Dright);
        GUILayout.Label("Gamepad 3 L1: " + G3L1);
        GUILayout.Label("Gamepad 3 R1: " + G3R1);
        GUILayout.Label("Gamepad 3 L3: " + G3L3);
        GUILayout.Label("Gamepad 3 R3: " + G3R3);
        GUILayout.Label("Gamepad 3 Start: " + G3Start);
        GUILayout.Label("Gamepad 3 Back: " + G3Back);
        GUILayout.Label("Gamepad 3 LT: " + G3LT);
        GUILayout.Label("Gamepad 3 RT: " + G3RT);
        GUILayout.Label("Gamepad 3 LX: " + G3LX);
        GUILayout.Label("Gamepad 3 LY: " + G3LY);
        GUILayout.Label("Gamepad 3 RX: " + G3RX);
        GUILayout.Label("Gamepad 3 RY: " + G3RY);
        GUILayout.EndVertical();

        GUILayout.BeginVertical("box", GUILayout.Width(200));
        GUILayout.Label("Gamepad 4 A: " + G4A);
        GUILayout.Label("Gamepad 4 B: " + G4B);
        GUILayout.Label("Gamepad 4 X: " + G4X);
        GUILayout.Label("Gamepad 4 Y: " + G4Y);
        GUILayout.Label("Gamepad 4 Up: " + G4Dup);
        GUILayout.Label("Gamepad 4 Down: " + G4Ddown);
        GUILayout.Label("Gamepad 4 Left: " + G4Dleft);
        GUILayout.Label("Gamepad 4 Right: " + G4Dright);
        GUILayout.Label("Gamepad 4 L1: " + G4L1);
        GUILayout.Label("Gamepad 4 R1: " + G4R1);
        GUILayout.Label("Gamepad 4 L3: " + G4L3);
        GUILayout.Label("Gamepad 4 R3: " + G4R3);
        GUILayout.Label("Gamepad 4 Start: " + G4Start);
        GUILayout.Label("Gamepad 4 Back: " + G4Back);
        GUILayout.Label("Gamepad 4 LT: " + G4LT);
        GUILayout.Label("Gamepad 4 RT: " + G4RT);
        GUILayout.Label("Gamepad 4 LX: " + G4LX);
        GUILayout.Label("Gamepad 4 LY: " + G4LY);
        GUILayout.Label("Gamepad 4 RX: " + G4RX);
        GUILayout.Label("Gamepad 4 RY: " + G4RY);
        GUILayout.EndVertical();

        GUILayout.EndHorizontal();
    }
}