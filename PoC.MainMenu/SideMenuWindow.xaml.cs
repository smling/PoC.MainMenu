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

namespace PoC.MainMenu
{
    /// <summary>
    /// Interaction logic for SideMenuWindow.xaml
    /// </summary>
    public partial class SideMenuWindow : Window
    {
        public SideMenuWindow()
        {
            InitializeComponent();
        }

        private void menuItemAddNewTab_Click(object sender, RoutedEventArgs e)
        {
            this.tabWorkingBench.Items.Add(new TabItem() { Header = "New Tab Item " + (tabWorkingBench.Items.Count - 1).ToString() });
        }
    }
}
