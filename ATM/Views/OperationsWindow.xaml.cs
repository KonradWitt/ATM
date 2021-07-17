using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace ATM
{
    public partial class OperationsWindow : Window
    {
        Session session;
        public OperationsWindow(Session _session)
        {
            InitializeComponent();
            session = _session;
        }

        private void OperationsWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonWithdraw_Click(object sender, RoutedEventArgs e)
        {
            WithdrawalWindow nextWindow = new WithdrawalWindow(session);
            nextWindow.Top = Top;
            nextWindow.Left = Left;
            nextWindow.Show();
            Close();
        }

        private void ButtonCheckBalance_Click(object sender, RoutedEventArgs e)
        {
            string message; 
            session.CheckBalance(out message);
            OpSummaryWindow nextWindow = new OpSummaryWindow(session, message);
            nextWindow.Top = Top;
            nextWindow.Left = Left;
            nextWindow.Show();
            Close();
        }

        private void ButtonDeposit_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow nextWindow = new DepositWindow(session);
            nextWindow.Top = Top;
            nextWindow.Left = Left;
            nextWindow.Show();
            Close();
        }

        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            session.CloseSession();
            LoginWindow nextWindow = new LoginWindow();
            nextWindow.Top = Top;
            nextWindow.Left = Left;
            nextWindow.Show();
            Close();
        }
    }
}
