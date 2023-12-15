using System;
using System.Collections.Generic;
using WindowsInput.Native;

public static class VirtualKeyCodes
{
    /*
     *VK_CANCEL (0x03): Control-break processing.

       These values are part of the set of virtual key codes used by the Windows operating system to represent different keys on the keyboard. They are often used in conjunction with functions like GetAsyncKeyState or GetKeyState in Windows API programming to check the state of specific keys. Keep in mind that these codes might have different interpretations in specific contexts, and some applications or systems might use them differently.
     */
    public static VirtualKeyCode GetVirtualKeyCode(char key)
    {
        if (AlphaNumericKeyCodes.TryGetValue(key, out var code))
        {
            return code;
        }

        throw new ArgumentException($"The key {key} is not a valid alpha numeric key.");
    }

    public static ushort GetUShort(char key)
    {
        if (AlphaNumericKeys.TryGetValue(key, out var code))
        {
            return code;
        }

        throw new ArgumentException($"The key {key} is not a valid alpha numeric key.");
    }

    private static readonly Dictionary<char, VirtualKeyCode> AlphaNumericKeyCodes = new Dictionary<char, VirtualKeyCode>
    {
        { 'A', VirtualKeyCode.VK_A },
        { 'B', VirtualKeyCode.VK_B },
        { 'C', VirtualKeyCode.VK_C },
        { 'D', VirtualKeyCode.VK_D },
        { 'E', VirtualKeyCode.VK_E },
        { 'F', VirtualKeyCode.VK_F },
        { 'G', VirtualKeyCode.VK_G },
        { 'H', VirtualKeyCode.VK_H },
        { 'I', VirtualKeyCode.VK_I },
        { 'J', VirtualKeyCode.VK_J },
        { 'K', VirtualKeyCode.VK_K },
        { 'L', VirtualKeyCode.VK_L },
        { 'M', VirtualKeyCode.VK_M },
        { 'N', VirtualKeyCode.VK_N },
        { 'O', VirtualKeyCode.VK_O },
        { 'P', VirtualKeyCode.VK_P },
        { 'Q', VirtualKeyCode.VK_Q },
        { 'R', VirtualKeyCode.VK_R },
        { 'S', VirtualKeyCode.VK_S },
        { 'T', VirtualKeyCode.VK_T },
        { 'U', VirtualKeyCode.VK_U },
        { 'V', VirtualKeyCode.VK_V },
        { 'W', VirtualKeyCode.VK_W },
        { 'X', VirtualKeyCode.VK_X },
        { 'Y', VirtualKeyCode.VK_Y },
        { 'Z', VirtualKeyCode.VK_Z },
        { '0', VirtualKeyCode.VK_0 },
        { '1', VirtualKeyCode.VK_1 },
        { '2', VirtualKeyCode.VK_2 },
        { '3', VirtualKeyCode.VK_3 },
        { '4', VirtualKeyCode.VK_4 },
        { '5', VirtualKeyCode.VK_5 },
        { '6', VirtualKeyCode.VK_6 },
        { '7', VirtualKeyCode.VK_7 },
        { '8', VirtualKeyCode.VK_8 },
        { '9', VirtualKeyCode.VK_9 }
    };
    private static readonly Dictionary<char, ushort> AlphaNumericKeys = new Dictionary<char, ushort>
    {
        { 'A', 0x41 },
        { 'B', 0x42 },
        { 'C', 0x43 },
        { 'D', 0x44 },
        { 'E', 0x45 },
        { 'F', 0x46 },
        { 'G', 0x47 },
        { 'H', 0x48 },
        { 'I', 0x49 },
        { 'J', 0x4A },
        { 'K', 0x4B },
        { 'L', 0x4C },
        { 'M', 0x4D },
        { 'N', 0x4E },
        { 'O', 0x4F },
        { 'P', 0x50 },
        { 'Q', 0x51 },
        { 'R', 0x52 },
        { 'S', 0x53 },
        { 'T', 0x54 },
        { 'U', 0x55 },
        { 'V', 0x56 },
        { 'W', 0x57 },
        { 'X', 0x58 },
        { 'Y', 0x59 },
        { 'Z', 0x5A },
        { '0', 0x30 },
        { '1', 0x31 },
        { '2', 0x32 },
        { '3', 0x33 },
        { '4', 0x34 },
        { '5', 0x35 },
        { '6', 0x36 },
        { '7', 0x37 },
        { '8', 0x38 },
        { '9', 0x39 }
    };
    public static readonly ushort A = AlphaNumericKeys['A'];
    public static readonly ushort B = AlphaNumericKeys['B'];
    public static readonly ushort C = AlphaNumericKeys['C'];
    public static readonly ushort D = AlphaNumericKeys['D'];
    public static readonly ushort E = AlphaNumericKeys['E'];
    public static readonly ushort F = AlphaNumericKeys['F'];
    public static readonly ushort G = AlphaNumericKeys['G'];
    public static readonly ushort H = AlphaNumericKeys['H'];
    public static readonly ushort I = AlphaNumericKeys['I'];
    public static readonly ushort J = AlphaNumericKeys['J'];
    public static readonly ushort K = AlphaNumericKeys['K'];
    public static readonly ushort L = AlphaNumericKeys['L'];
    public static readonly ushort M = AlphaNumericKeys['M'];
    public static readonly ushort N = AlphaNumericKeys['N'];
    public static readonly ushort O = AlphaNumericKeys['O'];
    public static readonly ushort P = AlphaNumericKeys['P'];
    public static readonly ushort Q = AlphaNumericKeys['Q'];
    public static readonly ushort R = AlphaNumericKeys['R'];
    public static readonly ushort S = AlphaNumericKeys['S'];
    public static readonly ushort T = AlphaNumericKeys['T'];
    public static readonly ushort U = AlphaNumericKeys['U'];
    public static readonly ushort V = AlphaNumericKeys['V'];
    public static readonly ushort W = AlphaNumericKeys['W'];
    public static readonly ushort X = AlphaNumericKeys['X'];
    public static readonly ushort Y = AlphaNumericKeys['Y'];
    public static readonly ushort Z = AlphaNumericKeys['Z'];

    public static readonly ushort Num0 = AlphaNumericKeys['0'];
    public static readonly ushort Num1 = AlphaNumericKeys['1'];
    public static readonly ushort Num2 = AlphaNumericKeys['2'];
    public static readonly ushort Num3 = AlphaNumericKeys['3'];
    public static readonly ushort Num4 = AlphaNumericKeys['4'];
    public static readonly ushort Num5 = AlphaNumericKeys['5'];
    public static readonly ushort Num6 = AlphaNumericKeys['6'];
    public static readonly ushort Num7 = AlphaNumericKeys['7'];
    public static readonly ushort Num8 = AlphaNumericKeys['8'];
    public static readonly ushort Num9 = AlphaNumericKeys['9'];


    public static readonly ushort F1 = 0x70;
    public static readonly ushort F2 = 0x71;
    public static readonly ushort F3 = 0x72;
    public static readonly ushort F4 = 0x73;
    public static readonly ushort F5 = 0x74;
    public static readonly ushort F6 = 0x75;
    public static readonly ushort F7 = 0x76;
    public static readonly ushort F8 = 0x77;
    public static readonly ushort F9 = 0x78;
    public static readonly ushort F10 = 0x79;
    public static readonly ushort F11 = 0x7A;
    public static readonly ushort F12 = 0x7B;
    public static readonly ushort F13 = 0x7C;
    public static readonly ushort F14 = 0x7D;
    public static readonly ushort F15 = 0x7E;
    public static readonly ushort F16 = 0x7F;
    public static readonly ushort F17 = 0x80;
    public static readonly ushort F18 = 0x81;
    public static readonly ushort F19 = 0x82;
    public static readonly ushort F20 = 0x83;
    public static readonly ushort F21 = 0x84;
    public static readonly ushort F22 = 0x85;
    public static readonly ushort F23 = 0x86;
    public static readonly ushort F24 = 0x87;
    public static readonly ushort VK_BACKSPACE = (0x08);// : Backspace key.
    public static readonly ushort VK_TAB = (0x09);//: Tab key.
    public static readonly ushort VK_CLEAR = (0x0C);//: Clear key.
    public static readonly ushort VK_RETURN = (0x0D);//: Enter key.
    public static readonly ushort VK_SHIFT = (0x10);//: Shift key.
    public static readonly ushort VK_CONTROL = (0x11);//: Ctrl key.
    public static readonly ushort VK_MENU = (0x12);//: Alt key.
}