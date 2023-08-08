//SlowPoke
// Type: Flintstones.UserActivityHook
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Flintstones
{
  public class UserActivityHook
  {
    private const int WH_MOUSE_LL = 14;
    private const int WH_KEYBOARD_LL = 13;
    private const int WH_MOUSE = 7;
    private const int WH_KEYBOARD = 2;
    private const int WM_MOUSEMOVE = 512;
    private const int WM_LBUTTONDOWN = 513;
    private const int WM_RBUTTONDOWN = 516;
    private const int WM_MBUTTONDOWN = 519;
    private const int WM_LBUTTONUP = 514;
    private const int WM_RBUTTONUP = 517;
    private const int WM_MBUTTONUP = 520;
    private const int WM_LBUTTONDBLCLK = 515;
    private const int WM_RBUTTONDBLCLK = 518;
    private const int WM_MBUTTONDBLCLK = 521;
    private const int WM_MOUSEWHEEL = 522;
    private const int WM_KEYDOWN = 256;
    private const int WM_KEYUP = 257;
    private const int WM_SYSKEYDOWN = 260;
    private const int WM_SYSKEYUP = 261;
    private const byte VK_SHIFT = 16;
    private const byte VK_CAPITAL = 20;
    private const byte VK_NUMLOCK = 144;
    private int hMouseHook;
    private int hKeyboardHook;
    private static UserActivityHook.HookProc KeyboardHookProcedure;
    private static UserActivityHook.HookProc MouseHookProcedure;

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
    private static extern int SetWindowsHookEx(
      int idHook,
      UserActivityHook.HookProc lpfn,
      IntPtr hMod,
      int dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
    private static extern int UnhookWindowsHookEx(int idHook);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

    [DllImport("user32")]
    private static extern int ToAscii(
      int uVirtKey,
      int uScanCode,
      byte[] lpbKeyState,
      byte[] lpwTransKey,
      int fuState);

    [DllImport("user32")]
    private static extern int GetKeyboardState(byte[] pbKeyState);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern short GetKeyState(int vKey);

    public UserActivityHook() => this.Start();

    public UserActivityHook(bool InstallMouseHook, bool InstallKeyboardHook) => this.Start(InstallMouseHook, InstallKeyboardHook);

    ~UserActivityHook() => this.Stop(true, true, false);

    public event MouseEventHandler OnMouseActivity;

    public event KeyEventHandler KeyDown;

    public event KeyPressEventHandler KeyPress;

    public event KeyEventHandler KeyUp;

    public void Start() => this.Start(true, true);

    public void Start(bool InstallMouseHook, bool InstallKeyboardHook)
    {
      if (this.hMouseHook == 0 & InstallMouseHook)
      {
        UserActivityHook.MouseHookProcedure = new UserActivityHook.HookProc(this.MouseHookProc);
        this.hMouseHook = UserActivityHook.SetWindowsHookEx(14, UserActivityHook.MouseHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
        if (this.hMouseHook == 0)
        {
          int lastWin32Error = Marshal.GetLastWin32Error();
          this.Stop(true, false, false);
          throw new Win32Exception(lastWin32Error);
        }
      }
      if (!(this.hKeyboardHook == 0 & InstallKeyboardHook))
        return;
      UserActivityHook.KeyboardHookProcedure = new UserActivityHook.HookProc(this.KeyboardHookProc);
      this.hKeyboardHook = UserActivityHook.SetWindowsHookEx(13, UserActivityHook.KeyboardHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
      if (this.hKeyboardHook != 0)
        return;
      Marshal.GetLastWin32Error();
      this.Stop(false, true, false);
    }

    public void Stop() => this.Stop(true, true, true);

    public void Stop(bool UninstallMouseHook, bool UninstallKeyboardHook, bool ThrowExceptions)
    {
      if (this.hMouseHook != 0 & UninstallMouseHook)
      {
        int num = UserActivityHook.UnhookWindowsHookEx(this.hMouseHook);
        this.hMouseHook = 0;
        if (num == 0 & ThrowExceptions)
          throw new Win32Exception(Marshal.GetLastWin32Error());
      }
      if (!(this.hKeyboardHook != 0 & UninstallKeyboardHook))
        return;
      int num1 = UserActivityHook.UnhookWindowsHookEx(this.hKeyboardHook);
      this.hKeyboardHook = 0;
      if (!(num1 == 0 & ThrowExceptions))
        return;
      Marshal.GetLastWin32Error();
    }

    private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
    {
      bool flag1 = false;
      if (nCode >= 0 && (this.KeyDown != null || this.KeyUp != null || this.KeyPress != null))
      {
        UserActivityHook.KeyboardHookStruct structure = (UserActivityHook.KeyboardHookStruct) Marshal.PtrToStructure(lParam, typeof (UserActivityHook.KeyboardHookStruct));
        if (this.KeyDown != null && (wParam == 256 || wParam == 260))
        {
          KeyEventArgs e = new KeyEventArgs((Keys) structure.vkCode);
          this.KeyDown((object) this, e);
          flag1 = flag1 || e.Handled;
        }
        if (this.KeyPress != null && wParam == 256)
        {
          bool flag2 = ((int) UserActivityHook.GetKeyState(16) & 128) == 128;
          bool flag3 = UserActivityHook.GetKeyState(20) != (short) 0;
          byte[] numArray = new byte[256];
          UserActivityHook.GetKeyboardState(numArray);
          byte[] lpwTransKey = new byte[2];
          if (UserActivityHook.ToAscii(structure.vkCode, structure.scanCode, numArray, lpwTransKey, structure.flags) == 1)
          {
            char upper = (char) lpwTransKey[0];
            if (flag3 ^ flag2 && char.IsLetter(upper))
              upper = char.ToUpper(upper);
            KeyPressEventArgs e = new KeyPressEventArgs(upper);
            this.KeyPress((object) this, e);
            flag1 = flag1 || e.Handled;
          }
        }
        if (this.KeyUp != null && (wParam == 257 || wParam == 261))
        {
          KeyEventArgs e = new KeyEventArgs((Keys) structure.vkCode);
          this.KeyUp((object) this, e);
          flag1 = flag1 || e.Handled;
        }
      }
      return !flag1 ? UserActivityHook.CallNextHookEx(this.hKeyboardHook, nCode, wParam, lParam) : 1;
    }

    private int MouseHookProc(int nCode, int wParam, IntPtr lParam)
    {
      if (nCode >= 0 && this.OnMouseActivity != null)
      {
        UserActivityHook.MouseLLHookStruct structure = (UserActivityHook.MouseLLHookStruct) Marshal.PtrToStructure(lParam, typeof (UserActivityHook.MouseLLHookStruct));
        MouseButtons button = MouseButtons.None;
        short delta = 0;
        switch (wParam)
        {
          case 513:
            button = MouseButtons.Left;
            break;
          case 516:
            button = MouseButtons.Right;
            break;
          case 522:
            delta = (short) (structure.mouseData >> 16 & (int) ushort.MaxValue);
            break;
        }
        int clicks = 0;
        if (button != MouseButtons.None)
          clicks = wParam == 515 || wParam == 518 ? 2 : 1;
        this.OnMouseActivity((object) this, new MouseEventArgs(button, clicks, structure.pt.x, structure.pt.y, (int) delta));
      }
      return UserActivityHook.CallNextHookEx(this.hMouseHook, nCode, wParam, lParam);
    }

    [StructLayout(LayoutKind.Sequential)]
    private class POINT
    {
      public int x;
      public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    private class MouseHookStruct
    {
      public UserActivityHook.POINT pt;
      public int hwnd;
      public int wHitTestCode;
      public int dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    private class MouseLLHookStruct
    {
      public UserActivityHook.POINT pt;
      public int mouseData;
      public int flags;
      public int time;
      public int dwExtraInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    private class KeyboardHookStruct
    {
      public int vkCode;
      public int scanCode;
      public int flags;
      public int time;
      public int dwExtraInfo;
    }

    private delegate int HookProc(int nCode, int wParam, IntPtr lParam);
  }
}
