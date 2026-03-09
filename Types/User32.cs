//SlowPoke
// Type: Flintstones.User32
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Flintstones
{
  public static class User32
  {
    private const int SW_HIDE = 0;
    private const int SW_SHOW = 1;

    public static void _MouseClick(IntPtr hwnd, int x, int y, int lrg)
    {
      User32._PostMessage(hwnd, 512, 0, User32.MakeLParam(x * lrg, y * lrg));
      User32._PostMessage(hwnd, 513, 1, User32.MakeLParam(x * lrg, y * lrg));
      User32._PostMessage(hwnd, 514, 1, User32.MakeLParam(x * lrg, y * lrg));
    }

    public static void PopupHitReturn(IntPtr hwnd)
    {
      User32._PostMessage(hwnd, 256, 13, User32.MakeLParam(1, User32.MapVirtualKey(13, 0)));
      User32._PostMessage(hwnd, 257, 13, User32.MakeLParam(1, User32.MapVirtualKey(13, 0)));
    }

    public static void _SendKeys(IntPtr hwnd, string keys)
    {
      if (keys.Equals("F1"))
      {
        User32._PostMessage(hwnd, 256, 112, User32.MakeLParam(1, User32.MapVirtualKey(112, 0)));
        User32._PostMessage(hwnd, 257, 112, User32.MakeLParam(1, User32.MapVirtualKey(112, 0)));
      }
      else if (keys.Equals("F5"))
      {
        User32._PostMessage(hwnd, 256, 116, User32.MakeLParam(1, User32.MapVirtualKey(116, 0)));
        User32._PostMessage(hwnd, 257, 116, User32.MakeLParam(1, User32.MapVirtualKey(116, 0)));
      }
      else if (keys.Equals("F12"))
      {
        User32._PostMessage(hwnd, 256, 123, User32.MakeLParam(1, User32.MapVirtualKey(123, 0)));
        User32._PostMessage(hwnd, 257, 123, User32.MakeLParam(1, User32.MapVirtualKey(123, 0)));
      }
      else if (keys.Equals("Esc"))
      {
        User32._PostMessage(hwnd, 256, 27, User32.MakeLParam(1, User32.MapVirtualKey(27, 0)));
        User32._PostMessage(hwnd, 257, 27, User32.MakeLParam(1, User32.MapVirtualKey(27, 0)));
      }
      else if (keys.Equals("Space"))      {
        User32._PostMessage(hwnd, 256, 32, User32.MakeLParam(1, User32.MapVirtualKey(32, 0)));
        User32._PostMessage(hwnd, 257, 32, User32.MakeLParam(1, User32.MapVirtualKey(32, 0)));
      }
      else if (keys.Equals("Enter"))
      {
        User32._PostMessage(hwnd, 256, 13, User32.MakeLParam(1, User32.MapVirtualKey(13, 0)));
        User32._PostMessage(hwnd, 257, 13, User32.MakeLParam(1, User32.MapVirtualKey(13, 0)));
      }
      else
      {
        bool flag = false;
        byte[] numArray1 = new byte[1];
        for (int startIndex = 0; startIndex < keys.Length; ++startIndex)
        {
          char[] charArray = keys.Substring(startIndex, 1).ToCharArray();
          if (char.IsLetter(charArray[0]) && char.IsUpper(charArray[0]))
          {
            User32._PostMessage(hwnd, 256, 16, User32.MakeLParam(1, User32.MapVirtualKey(16, 0)));
            flag = true;
          }
          byte[] numArray2 = !char.IsLetter(charArray[0]) ? Encoding.ASCII.GetBytes(keys.Substring(startIndex, 1)) : Encoding.ASCII.GetBytes(keys.Substring(startIndex, 1).ToUpper());
          if (keys.Substring(startIndex, 1) == "-")
            numArray2[0] = (byte) 109;
          if (keys.Substring(startIndex, 1) == "~")
            numArray2[0] = (byte) 192;
          User32._PostMessage(hwnd, 256, (int) numArray2[0], User32.MakeLParam(1, User32.MapVirtualKey((int) numArray2[0], 0)));
          User32._PostMessage(hwnd, 257, (int) numArray2[0], User32.MakeLParam(1, User32.MapVirtualKey((int) numArray2[0], 0)));
          if (flag)
          {
            User32._PostMessage(hwnd, 257, 16, User32.MakeLParam(1, User32.MapVirtualKey(16, 0)));
            flag = false;
          }
        }
      }
    }

    public static void _SendText(IntPtr hwnd, string text)
    {
      foreach (char wParam in text.ToCharArray())
        User32._PostMessage(hwnd, 258, (int) wParam, 0);
    }

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    internal static extern int MapVirtualKey(int uCode, int uMapType);

    [DllImport("user32.dll")]
    internal static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll")]
    internal static extern bool BringWindowToTop(IntPtr hWnd);

    [DllImport("user32.dll", EntryPoint = "FindWindow")]
    internal static extern int FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

    [DllImport("user32.dll")]
    internal static extern int ShowWindow(int hwnd, int command);

    [DllImport("user32.dll")]
    internal static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    internal static extern bool GetWindowRect(IntPtr hwnd, out Rect rectangle);

    [DllImport("user32.dll")]
    internal static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

    [DllImport("user32.dll")]
    internal static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll")]
    internal static extern int GetWindowTextLength(IntPtr hWnd);

    internal static string GetWindowText(IntPtr hWnd)
    {
      StringBuilder lpString = new StringBuilder(User32.GetWindowTextLength(hWnd) + 1);
      User32.GetWindowText(hWnd, lpString, lpString.Capacity);
      return lpString.ToString();
    }

    private static int Handle => User32.FindWindowByCaption(IntPtr.Zero, "renktools 2020");

    public static void Show() => User32.ShowWindow(User32.Handle, 1);

    public static void Hide() => User32.ShowWindow(User32.Handle, 0);

    public static void _PostMessage(IntPtr handle, int Msg, int wParam, int lParam) => User32.PostMessage(handle, Msg, wParam, lParam);

    public static int MakeLParam(int LoWord, int HiWord) => HiWord << 16 | LoWord & (int) ushort.MaxValue;

    public enum WMessages
    {
      WM_KEYDOWN = 256, // 0x00000100
      WM_KEYUP = 257, // 0x00000101
      WM_CHAR = 258, // 0x00000102
      WM_MOUSEMOVE = 512, // 0x00000200
      WM_LBUTTONDOWN = 513, // 0x00000201
      WM_LBUTTONUP = 514, // 0x00000202
      WM_LBUTTONDBLCLK = 515, // 0x00000203
      WM_RBUTTONDOWN = 516, // 0x00000204
      WM_RBUTTONUP = 517, // 0x00000205
      WM_RBUTTONDBLCLK = 518, // 0x00000206
    }

    public enum VKeys
    {
      VK_LBUTTON = 1,
      VK_RBUTTON = 2,
      VK_CANCEL = 3,
      VK_MBUTTON = 4,
      VK_BACK = 8,
      VK_TAB = 9,
      VK_CLEAR = 12, // 0x0000000C
      VK_RETURN = 13, // 0x0000000D
      VK_SHIFT = 16, // 0x00000010
      VK_CONTROL = 17, // 0x00000011
      VK_MENU = 18, // 0x00000012
      VK_PAUSE = 19, // 0x00000013
      VK_CAPITAL = 20, // 0x00000014
      VK_ESCAPE = 27, // 0x0000001B
      VK_SPACE = 32, // 0x00000020
      VK_PRIOR = 33, // 0x00000021
      VK_NEXT = 34, // 0x00000022
      VK_END = 35, // 0x00000023
      VK_HOME = 36, // 0x00000024
      VK_LEFT = 37, // 0x00000025
      VK_UP = 38, // 0x00000026
      VK_RIGHT = 39, // 0x00000027
      VK_DOWN = 40, // 0x00000028
      VK_SELECT = 41, // 0x00000029
      VK_PRINT = 42, // 0x0000002A
      VK_EXECUTE = 43, // 0x0000002B
      VK_SNAPSHOT = 44, // 0x0000002C
      VK_INSERT = 45, // 0x0000002D
      VK_DELETE = 46, // 0x0000002E
      VK_HELP = 47, // 0x0000002F
      VK_0 = 48, // 0x00000030
      VK_1 = 49, // 0x00000031
      VK_2 = 50, // 0x00000032
      VK_3 = 51, // 0x00000033
      VK_4 = 52, // 0x00000034
      VK_5 = 53, // 0x00000035
      VK_6 = 54, // 0x00000036
      VK_7 = 55, // 0x00000037
      VK_8 = 56, // 0x00000038
      VK_9 = 57, // 0x00000039
      VK_A = 65, // 0x00000041
      VK_B = 66, // 0x00000042
      VK_C = 67, // 0x00000043
      VK_D = 68, // 0x00000044
      VK_E = 69, // 0x00000045
      VK_F = 70, // 0x00000046
      VK_G = 71, // 0x00000047
      VK_H = 72, // 0x00000048
      VK_I = 73, // 0x00000049
      VK_J = 74, // 0x0000004A
      VK_K = 75, // 0x0000004B
      VK_L = 76, // 0x0000004C
      VK_M = 77, // 0x0000004D
      VK_N = 78, // 0x0000004E
      VK_O = 79, // 0x0000004F
      VK_P = 80, // 0x00000050
      VK_Q = 81, // 0x00000051
      VK_R = 82, // 0x00000052
      VK_S = 83, // 0x00000053
      VK_T = 84, // 0x00000054
      VK_U = 85, // 0x00000055
      VK_V = 86, // 0x00000056
      VK_W = 87, // 0x00000057
      VK_X = 88, // 0x00000058
      VK_Y = 89, // 0x00000059
      VK_Z = 90, // 0x0000005A
      VK_NUMPAD0 = 96, // 0x00000060
      VK_NUMPAD1 = 97, // 0x00000061
      VK_NUMPAD2 = 98, // 0x00000062
      VK_NUMPAD3 = 99, // 0x00000063
      VK_NUMPAD4 = 100, // 0x00000064
      VK_NUMPAD5 = 101, // 0x00000065
      VK_NUMPAD6 = 102, // 0x00000066
      VK_NUMPAD7 = 103, // 0x00000067
      VK_NUMPAD8 = 104, // 0x00000068
      VK_NUMPAD9 = 105, // 0x00000069
      VK_SEPARATOR = 108, // 0x0000006C
      VK_SUBTRACT = 109, // 0x0000006D
      VK_DECIMAL = 110, // 0x0000006E
      VK_DIVIDE = 111, // 0x0000006F
      VK_F1 = 112, // 0x00000070
      VK_F2 = 113, // 0x00000071
      VK_F3 = 114, // 0x00000072
      VK_F4 = 115, // 0x00000073
      VK_F5 = 116, // 0x00000074
      VK_F6 = 117, // 0x00000075
      VK_F7 = 118, // 0x00000076
      VK_F8 = 119, // 0x00000077
      VK_F9 = 120, // 0x00000078
      VK_F10 = 121, // 0x00000079
      VK_F11 = 122, // 0x0000007A
      VK_F12 = 123, // 0x0000007B
      VK_SCROLL = 145, // 0x00000091
      VK_LSHIFT = 160, // 0x000000A0
      VK_RSHIFT = 161, // 0x000000A1
      VK_LCONTROL = 162, // 0x000000A2
      VK_RCONTROL = 163, // 0x000000A3
      VK_LMENU = 164, // 0x000000A4
      VK_RMENU = 165, // 0x000000A5
      VK_TILDE = 192, // 0x000000C0
      VK_PLAY = 250, // 0x000000FA
      VK_ZOOM = 251, // 0x000000FB
    }
  }
}
