//SlowPoke
// Type: Flintstones.ListViewItemComparer
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections;
using System.Windows.Forms;

namespace Flintstones
{
  internal class ListViewItemComparer : IComparer
  {
    private int col;
    private SortOrder order;

    public ListViewItemComparer()
    {
      this.col = 0;
      this.order = SortOrder.Ascending;
    }

    public ListViewItemComparer(int column, SortOrder order)
    {
      this.col = column;
      this.order = order;
    }

    public int Compare(object x, object y)
    {
      int num = -1;
      try
      {
        num = string.Compare(((ListViewItem) x).SubItems[this.col].Text, ((ListViewItem) y).SubItems[this.col].Text);
        if (this.order == SortOrder.Descending)
          num *= -1;
      }
      catch
      {
        return num;
      }
      return num;
    }
  }
}
