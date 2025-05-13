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

namespace Pr_rob3_vp
{
    /// <summary>
    /// Логика взаимодействия для MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();

            usernameBox.KeyDown += Input_KeyDown;
            passwordBox.KeyDown += Input_KeyDown;
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                button_Click(sender, e);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Password;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                messageBlock.Text = "Вхід успішний!";
                messageBlock.Foreground = Brushes.Green;
            }
            else
            {
                messageBlock.Text = "Будь ласка, заповніть усі поля!";
                messageBlock.Foreground = Brushes.Red;
            }
        }
    }
}
