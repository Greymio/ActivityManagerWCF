using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFActivityManager.Views
{
    /// <summary>
    /// Interaction logic for ActivityView.xaml
    /// </summary>
    public partial class ActivityView 
    {
        public ActivityView()
        {
            InitializeComponent();
        }

        private void ShowHideDetails(object sender, RoutedEventArgs e)
        {
            DetailsFlyout.IsOpen = true;
        }
    }
}
