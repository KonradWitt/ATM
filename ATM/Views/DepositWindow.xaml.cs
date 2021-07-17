
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;


namespace ATM
{
    public partial class DepositWindow : Window
    {
        Session session;
        public DepositWindow(Session _session)
        {
            InitializeComponent();
            session = _session;
        }

        private void DepositWindow_MouseDown(object sender, MouseButtonEventArgs e)
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
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void Button50_Click(object sender, RoutedEventArgs e)
        {
            DepositAmount.Text = 50.ToString();
        }

        private void Button100_Click(object sender, RoutedEventArgs e)
        {
            DepositAmount.Text = 100.ToString();
        }

        private void Button150_Click(object sender, RoutedEventArgs e)
        {
            DepositAmount.Text = 150.ToString();
        }

        private void Button200_Click(object sender, RoutedEventArgs e)
        {
            DepositAmount.Text = 200.ToString();
        }

        private void Button250_Click(object sender, RoutedEventArgs e)
        {
            DepositAmount.Text = 250.ToString();
        }

        private void Button300_Click(object sender, RoutedEventArgs e)
        {
            DepositAmount.Text = 300.ToString();
        }

        private void DepositAmount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ButtonDeposit_Click(object sender, RoutedEventArgs e)
        {
            string message;
            session.PayIn(Convert.ToDouble(DepositAmount.Text), out message);
            OpSummaryWindow nextWindow = new OpSummaryWindow(session, message);
            nextWindow.Top = Top;
            nextWindow.Left = Left;
            nextWindow.Show();
            Close();
        }

        private void DepositAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ButtonDeposit != null && DepositAmount.Text.Length > 0)
            {
                ButtonDeposit.IsEnabled = true;
            }
        }
    }
}
