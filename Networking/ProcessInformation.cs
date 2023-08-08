//SlowPoke
// Type: Flintstones.ProcessInformation
//SlowPoke
//SlowPoke
//SlowPoke

using System;

namespace Flintstones
{
  public struct ProcessInformation
  {
    public IntPtr ProcessHandle { get; set; }

    public IntPtr ThreadHandle { get; set; }

    public int ProcessId { get; set; }

    public int ThreadId { get; set; }
  }
}
