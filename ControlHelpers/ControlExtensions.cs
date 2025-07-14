using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slowpoke.ControlHelpers
{
    public static class ControlExtensions
    {
        public static void RemoveSelfFromParentTab(this UserControl control)
        {
            var parent = control.Parent;
            while (parent != null && !(parent is TabPage))
                parent = parent.Parent;

            if (parent is TabPage tab && tab.Parent is TabControl tabControl)
            {
                tabControl.TabPages.Remove(tab);
                control.Dispose();
                tab.Dispose();
            }
        }
    }
}

