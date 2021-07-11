using System.Windows;
using System.Windows.Input;


namespace ATM
{
    public partial class OpSummaryWindow : Window
    {
        Session session;
        string message;
        public OpSummaryWindow(Session _session, string _message)
        {      
            InitializeComponent();
            session = _session;
            message = _message;
            TextBlock.Text = message;
        }

        private void OpSummaryWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonProceed_Click(object sender, RoutedEventArgs e)
        {
            OperationsWindow nextWindow = new OperationsWindow(session);
            nextWindow.Top = this.Top;
            nextWindow.Left = this.Left;
            nextWindow.Show();
            this.Close();
        }
    }
}
