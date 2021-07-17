using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;


namespace ATM
{
    public partial class LoginWindow : Window
    {
        private bool textBoxHadFocus;
        private bool passwordBoxHadFocus;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;    
            textBoxHadFocus = true;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox pb = (PasswordBox)sender;
            pb.Password = string.Empty;       
            passwordBoxHadFocus = true;
            pb.GotFocus -= PasswordBox_GotFocus;
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void PasswordBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Session session;
            string message;
            uint accountNumber;
            uint pin;

            try
            {
                accountNumber = Convert.ToUInt32(TextBox.Text);
                pin = Convert.ToUInt32(PasswordBox.Password);
            }
            catch
            {
                accountNumber = 0;
                pin = 0;
            }     

            if (LoginHelper.TryLogin(accountNumber, pin, out session, out message))
            {
                OperationsWindow nextWindow = new OperationsWindow(session)
                {
                    Top = Top,
                    Left = Left
                };
                nextWindow.Show();
                Close();
            }
            else
            {
                TextBlockInvalidLogin.Text = message;
                TextBlockInvalidLogin.Visibility = Visibility.Visible;
            }

        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow nextWindow = new AboutWindow();
            nextWindow.Top = Top;
            nextWindow.Left = Left;
            nextWindow.Show();
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ButtonLogin != null && textBoxHadFocus && TextBox.Text.Length > 0 && passwordBoxHadFocus && PasswordBox.Password.Length > 0)
            {
                ButtonLogin.IsEnabled = true;
            }

            if (TextBlockInvalidLogin != null)
            {
                TextBlockInvalidLogin.Visibility = Visibility.Hidden;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (ButtonLogin != null && textBoxHadFocus && TextBox.Text.Length > 0 && passwordBoxHadFocus && PasswordBox.Password.Length > 0)
            {
                ButtonLogin.IsEnabled = true;
            }

            if (TextBlockInvalidLogin != null)
            {
                TextBlockInvalidLogin.Visibility = Visibility.Hidden;
            }
        }

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
