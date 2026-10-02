using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Napló
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliJegyek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbJegyValtozas.Content = sliJegyek.Value.ToString();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string nev = txtNeve.Text;
            if (datDatum.SelectedDate.Value > DateTime.Now)
            {
                MessageBox.Show("Nem lehet jövőbeli időpontot beállítani!");

            }
            else if (!nev.Contains(" ") || nev.EndsWith(" ") || nev.StartsWith(" "))
            {
                MessageBox.Show("A név nem lehet egy tagú!");
            }
            else
            {
                string datum = datDatum.SelectedDate.Value.ToShortDateString();
                lsbJegyek.Items.Add($"{txtNeve.Text} - {datum} - {cbTantargyak.SelectionBoxItem} - {sliJegyek.Value}");
            }
        }
    }
}