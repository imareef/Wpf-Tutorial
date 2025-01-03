using System.Windows;
using System.Windows.Controls;

namespace Custom_Textbox_Control.View.UserControls
{
    public partial class CleareableTextBox : UserControl
    {

        private string placeHolder;

        public string PlaceHolder
        {
            get { return placeHolder; }
            set 
            { 
                placeHolder = value; 

                // do not do this - use onPropertyChanged()
                tbPlaceHolder.Text = placeHolder;
            }
        }


        public CleareableTextBox()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceHolder.Visibility = Visibility.Visible;
            else
                tbPlaceHolder.Visibility = Visibility.Hidden;
        }
    }
}
