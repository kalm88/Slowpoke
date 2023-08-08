//SlowPoke
// Type: ListViewColumnSorter
//SlowPoke
//SlowPoke
//SlowPoke

using System.Collections;
using System.Windows.Forms;

public class ListViewColumnSorter : IComparer
{
  private int ColumnToSort;
  private SortOrder OrderOfSort;
  private CaseInsensitiveComparer ObjectCompare;

  public ListViewColumnSorter()
  {
    this.ColumnToSort = 0;
    this.OrderOfSort = SortOrder.None;
    this.ObjectCompare = new CaseInsensitiveComparer();
  }

  public int Compare(object x, object y)
  {
    int num = this.ObjectCompare.Compare((object) ((ListViewItem) x).SubItems[this.ColumnToSort].Text, (object) ((ListViewItem) y).SubItems[this.ColumnToSort].Text);
    if (this.OrderOfSort == SortOrder.Ascending)
      return num;
    return this.OrderOfSort != SortOrder.Descending ? 0 : -num;
  }

  public int SortColumn
  {
    set => this.ColumnToSort = value;
    get => this.ColumnToSort;
  }

  public SortOrder Order
  {
    set => this.OrderOfSort = value;
    get => this.OrderOfSort;
  }
}
