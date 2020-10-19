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
using MaterialDesignThemes.Wpf;
using System.Windows.Shapes;

namespace Calculator
{

    public partial class MainWindow : Window
    {

        Operation operation;

        public MainWindow()
        {
            InitializeComponent();
            operation = new Operation();
            Text_result.Text = string.Empty;
            Text_current_operation.Text = string.Empty;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var currentNumber = button.Name[button.Name.Length - 1];
            Text_current_operation.Text += currentNumber.ToString();
        }


        private void Button_c_Click(object sender, RoutedEventArgs e)
        {
            Text_result.Text = string.Empty;
            Text_current_operation.Text = string.Empty;
        }

        private void Button_power_Click(object sender, RoutedEventArgs e)
        {
            Message_Box   message_Box  = new Message_Box();
            message_Box.ShowDialog();
        }

        private void Button_percent_Click(object sender, RoutedEventArgs e)
        {
            if (operation.containSign(Text_current_operation.Text) == true)
            {
                Text_result.Text = operation.Result(Text_current_operation.Text).ToString();
                Text_current_operation.Text = Text_result.Text + "%";
            }
            else
            {
                Text_current_operation.Text += "%";
            }

        }

        private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            if (Text_current_operation.Text.Length >= 1)
                Text_current_operation.Text = Text_current_operation.Text.Remove(Text_current_operation.Text.Length - 1);
        }

        private void Button_divide_Click(object sender, RoutedEventArgs e)
        {
            if (operation.containSign(Text_current_operation.Text) == true)
            {
                Text_result.Text = operation.Result(Text_current_operation.Text).ToString();
                Text_current_operation.Text = Text_result.Text + "/";
            }
            else
            {
                Text_current_operation.Text += "/";
            }
        }

        private void Button_multiple_Click(object sender, RoutedEventArgs e)
        {
            if (operation.containSign(Text_current_operation.Text) == true)
            {
                Text_result.Text = operation.Result(Text_current_operation.Text).ToString();
                Text_current_operation.Text = Text_result.Text + "*";
            }
            else
            {
                Text_current_operation.Text += "*";
            }
        }

        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            if (operation.containSign(Text_current_operation.Text) == true)
            {
                Text_result.Text = operation.Result(Text_current_operation.Text).ToString();
                Text_current_operation.Text = Text_result.Text + "+";
            }
            else
            {
                Text_current_operation.Text += "+";
            }
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            if (operation.containSign(Text_current_operation.Text) == true)
            {
                Text_result.Text = operation.Result(Text_current_operation.Text).ToString();
                Text_current_operation.Text = Text_result.Text + "-";
            }

            else
            {
                Text_current_operation.Text += "-";
            }
        }

        private void Button_dot_Click(object sender, RoutedEventArgs e)
        {
            if (Text_current_operation.Text == string.Empty)
            {
                Text_current_operation.Text += "0,";
            }
            else
            {
                Text_current_operation.Text += ",";
            }
        }


        private void Button_getResult_Click(object sender, RoutedEventArgs e)
        {
            Text_result.Text = operation.Result(Text_current_operation.Text).ToString();
            Text_current_operation.Text = string.Empty;
        }
    }
}
