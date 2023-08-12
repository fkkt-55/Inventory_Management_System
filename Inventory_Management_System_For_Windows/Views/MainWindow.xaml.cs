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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Inventory_Management_System_For_Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            BuyWindow buyWindow = BuyWindow.GetInstance();
            buyWindow.Show();
            Close();
#endif
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Buy_Click(object sender, RoutedEventArgs e)
        {
            BuyWindow buyWindow = BuyWindow.GetInstance();
            buyWindow.Show();
            Close();
        }

        private void MenuItem_Sell_Click(object sender, RoutedEventArgs e)
        {
            SellWindow sellWindow = new();
            sellWindow.Show();
            Close();
        }
    }

}
