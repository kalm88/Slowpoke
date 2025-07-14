//SlowPoke
// Type: Flintstones.Kernel32
//SlowPoke
//SlowPoke
//SlowPoke

using System;
using System.Runtime.InteropServices;

namespace Flintstones
{
    [Flags]
    public enum AllocationType
    {
        Commit = 0x1000,
        Reserve = 0x2000,
        Decommit = 0x4000,
        Release = 0x8000,
        Reset = 0x80000,
        Physical = 0x400000,
        TopDown = 0x100000,
        WriteWatch = 0x200000,
        LargePages = 0x20000000
    }

    [Flags]
    public enum MemoryProtection
    {
        Execute = 0x10,
        ExecuteRead = 0x20,
        ExecuteReadWrite = 0x40,
        ExecuteWriteCopy = 0x80,
        NoAccess = 0x01,
        ReadOnly = 0x02,
        ReadWrite = 0x04,
        WriteCopy = 0x08,
        GuardModifierflag = 0x100,
        NoCacheModifierflag = 0x200,
        WriteCombineModifierflag = 0x400
    }
    public static class Kernel32
    {
        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll")]
        public static extern bool CreateProcess(
          string applicationName,
          string commandLine,
          IntPtr processAttributes,
          IntPtr threadAttributes,
          bool inheritHandles,
          ProcessCreationFlags creationFlags,
          IntPtr environment,
          string currentDirectory,
          ref StartupInfo startupInfo,
          out ProcessInformation processInfo);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(
          ProcessAccess access,
          bool inheritHandle,
          int processId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(
          IntPtr hProcess,
          IntPtr baseAddress,
          IntPtr buffer,
          int count,
          out int bytesRead);

        [DllImport("kernel32.dll")]
        public static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        public static extern WaitEventResult WaitForSingleObject(
          IntPtr hObject,
          int timeout);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(
          IntPtr hProcess,
          IntPtr baseAddress,
          IntPtr buffer,
          int count,
          out int bytesWritten);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            uint dwSize,
            AllocationType flAllocationType,
            MemoryProtection flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualFreeEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            uint dwSize,
            AllocationType dwFreeType);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateRemoteThread(
            IntPtr hProcess,
            IntPtr lpThreadAttributes,
            uint dwStackSize,
            IntPtr lpStartAddress,
            IntPtr lpParameter,
            uint dwCreationFlags,
            IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds); // Using uint instead of int for WaitForSingleObject





        [Flags]
        public enum ProcessAccess
        {
            VmRead = 0x0010,
            VmWrite = 0x0020,
            VmOperation = 0x0008
        }
    }
}
