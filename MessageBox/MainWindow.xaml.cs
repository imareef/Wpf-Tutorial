using System.Windows;

namespace MessageBoxLearn
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
           
            MessageBoxResult result = MessageBox.Show("Do You Agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "agreed";
            }
            else
            {
                tbInfo.Text = "not agreed";
            }

        }
    }
}