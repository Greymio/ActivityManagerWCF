using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFActivityManager.Tools
{
    public interface IUIWindowDialogService
    {
        bool? ShowDialog(string title, object datacontext);
    }
}
