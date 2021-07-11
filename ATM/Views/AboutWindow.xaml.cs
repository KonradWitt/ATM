using System.Windows;
using System.Windows.Input;


namespace ATM
{
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void AboutWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow nextWindow = new LoginWindow();
            nextWindow.Top = this.Top;
            nextWindow.Left = this.Left;
            nextWindow.Show();
            this.Close();
        }
    }
}
