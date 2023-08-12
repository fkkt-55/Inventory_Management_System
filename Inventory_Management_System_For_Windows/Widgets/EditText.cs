using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Inventory_Management_System_For_Windows.Widgets
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Inventory_Management_System_For_Windows.Widgets"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:Inventory_Management_System_For_Windows.Widgets;assembly=Inventory_Management_System_For_Windows.Widgets"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:EditText/>
    ///
    /// </summary>
    public class EditText : TextBox
    {
        static EditText()
        {
            // DefaultStyleKeyProperty.OverrideMetadata(typeof(EditText), new FrameworkPropertyMetadata(typeof(EditText)));
        }

        public EditText()
        {
            PreviewTextInput += NumericTextBox_PreviewTextInput;
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPaste));
        }

        private void OnPaste(object sender, ExecutedRoutedEventArgs e)
        {
            // 在这里执行屏蔽粘贴操作的代码
            // Clipboard.Clear();
            // 取消粘贴操作
            e.Handled = true;
        }

        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Length == 0)
            {
                return;
            }

            char data = e.Text[0];

            if (!char.IsDigit(data) && data != '.')
            {
                e.Handled = true;
            }
            else if (data == '.' && this.Text.Contains('.'))
            {
                e.Handled = true;
            }

        }
    }
}
