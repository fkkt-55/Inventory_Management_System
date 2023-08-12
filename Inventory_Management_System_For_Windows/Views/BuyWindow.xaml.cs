using Inventory_Management_System_For_Windows.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace Inventory_Management_System_For_Windows
{
    /// <summary>
    /// BuyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BuyWindow : Window
    {
        private static BuyWindow? _instance;

        private BuyWindow()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            Text_Date.SelectedDate = DateTime.Now;
        }

        public static BuyWindow GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BuyWindow();
                _instance.Closed += (sender, e) => _instance = null;
            }
            return _instance;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string ProductName = Utility.EnsureStringIsNotNull(Text_ProductName.Text);
            string From = Utility.EnsureStringIsNotNull(Text_From.Text);
            DateTime? Date = Text_Date.SelectedDate;
            decimal Count = Utility.StringToDecimal(Text_Count.Text);
            decimal Price = Utility.StringToDecimal(Text_Price.Text);
            Text_AllPrice.Text = string.Format("{0:f} 元", Price * Count);
            
        }
    }
}
