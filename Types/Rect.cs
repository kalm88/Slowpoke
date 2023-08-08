//SlowPoke
// Type: Flintstones.Rect
//SlowPoke
//SlowPoke
//SlowPoke

namespace Flintstones
{
  public struct Rect
  {
    public int left;
    public int top;
    public int right;
    public int bottom;

    public int Width => this.right - this.left;

    public int Height => this.bottom - this.top;
  }
}
