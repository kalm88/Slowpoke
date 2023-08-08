//SlowPoke
// Type: Flintstones.WaitEventResult
//SlowPoke
//SlowPoke
//SlowPoke

namespace Flintstones
{
  public enum WaitEventResult
  {
    Signaled = 0,
    Abandoned = 128, // 0x00000080
    Timeout = 258, // 0x00000102
  }
}
