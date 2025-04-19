using System.Windows;
using System.Windows.Controls;

namespace WpfCustomControls.View.UserControls
{

    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value; 
                tbPlaceholder.Text = placeholder;
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //Cancellazione dati textboxt
            txtInput.Clear();

            //Risetta il cursore a inizio textbox
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            //se la casella non presenta testo
            if (string.IsNullOrEmpty(txtInput.Text))
                //rendi visibile il testo del componente placeholder
                tbPlaceholder.Visibility = Visibility.Visible;
            else
                tbPlaceholder.Visibility = Visibility.Hidden;
           
        }
    }
}
