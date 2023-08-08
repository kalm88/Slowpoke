//SlowPoke
// Type: Flintstones.Relog
//SlowPoke
//SlowPoke
//SlowPoke

using System.Diagnostics;

namespace Flintstones
{
  public class Relog
  {
    public string Name { get; set; }

    public Process Process { get; set; }

    public bool WaitForOk { get; set; }

    public bool Redirected { get; set; }

    public bool ServerReset { get; set; }
  }
}
