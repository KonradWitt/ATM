
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;


namespace ATM
{
    public partial class WithdrawalWindow : Window
    {
        Session session;
        public WithdrawalWindow(Session _session)
        {
            InitializeComponent();
            session = _session;
        }

        private void WithdrawalWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
        }

        private void Button50_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalAmount.Text = 50.ToString();
        }

        private void Button100_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalAmount.Text = 100.ToString();
        }

        private void Button150_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalAmount.Text = 150.ToString();
        }

        private void Button200_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalAmount.Text = 200.ToString();
        }

        private void Button250_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalAmount.Text = 250.ToString();
        }

        private void Button300_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalAmount.Text = 300.ToString();
        }

        private void WithdrawalAmount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ButtonWithdraw_Click(object sender, RoutedEventArgs e)
        {
            string message = session.PayOut(Convert.ToDouble(WithdrawalAmount.Text));
            OpSummaryWindow nextWindow = new OpSummaryWindow(session, message);
            nextWindow.Top = Top;
            nextWindow.Left = Left;
            nextWindow.Show();
            Close();
        }

        private void WithdrawalAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ButtonWithdraw != null && WithdrawalAmount.Text.Length > 0)
            {
                ButtonWithdraw.IsEnabled = true;
            }
        }
    }
}
