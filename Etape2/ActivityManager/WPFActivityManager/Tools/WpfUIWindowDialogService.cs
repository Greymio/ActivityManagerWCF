using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFActivityManager.Views.Modal;

namespace WPFActivityManager.Tools
{
    public class WpfUIWindowDialogService : IUIWindowDialogService
    {
        public bool? ShowDialog(string title, object datacontext)
        {
            var win = new WindowDialog();
            win.Title = title;
            win.DataContext = datacontext;

            return win.ShowDialog();
        }

    }
}
