//SlowPoke
// Type: Flintstones.ProcessCreationFlags
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  [Flags]
  public enum ProcessCreationFlags
  {
    DebugProcess = 1,
    DebugOnlyThisProcess = 2,
    Suspended = 4,
    DetachedProcess = 8,
    NewConsole = 16, // 0x00000010
    NewProcessGroup = 512, // 0x00000200
    UnicodeEnvironment = 1024, // 0x00000400
    SeparateWowVdm = 2048, // 0x00000800
    SharedWowVdm = 4096, // 0x00001000
    InheritParentAffinity = SharedWowVdm, // 0x00001000
    ProtectedProcess = 262144, // 0x00040000
    ExtendedStartupInfoPresent = 524288, // 0x00080000
    BreakawayFromJob = 16777216, // 0x01000000
    PreserveCodeAuthZLevel = 33554432, // 0x02000000
    DefaultErrorMode = 67108864, // 0x04000000
    NoWindow = 134217728, // 0x08000000
  }
}
