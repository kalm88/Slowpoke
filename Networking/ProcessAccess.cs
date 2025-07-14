//SlowPoke
// Type: Flintstones.ProcessAccess
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  [Flags]
  public enum ProcessAccess
  {
    None = 0,
    Terminate = 1,
    CreateThread = 2,
    VmOperation = 8,
    VmRead = 16, // 0x00000010
    VmWrite = 32, // 0x00000020
    DuplicateHandle = 64, // 0x00000040
    CreateProcess = 128, // 0x00000080
    SetQuota = 256, // 0x00000100
    SetInformation = 512, // 0x00000200
    QueryInformation = 1024, // 0x00000400
    SuspendResume = 2048, // 0x00000800
    QueryLimitedInformation = 4096, // 0x00001000
        AllAccess = 8192,
    }
}
