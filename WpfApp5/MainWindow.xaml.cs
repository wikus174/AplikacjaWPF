using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Currency> currency;
        public MainWindow()
        {
            InitializeComponent();

            currency = new List<Currency> {
                new Currency("Dolar Amerykański", "$", 1.0),
                new Currency("Złoty", "zł", 4.32),
                new Currency("Euro", "€", 0.92),
                new Currency("Funt Brytyjski", "£", 0.81),
                new Currency("Japoński Jen", "¥", 131.86),
                new Currency("Kanadyjski Dolar", "C$", 1.37)
            };
            zamiennalista.ItemsSource = currency;
            zamiennalista.DisplayMemberPath = "name";
            zamienzlista.ItemsSource = currency;
            zamienzlista.DisplayMemberPath = "name";

        }
        public Currency selectedCurrencyfrom;
        public Currency selectedCurrencyTo;
        private void zamienzlista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCurrencyfrom = zamienzlista.SelectedItem as Currency;
            if (selectedCurrencyfrom == null)
            {
                MessageBox.Show("wybierz walute z której chcesz zamienić");
            }
        }

        private void zamiennalista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCurrencyTo = zamiennalista.SelectedItem as Currency;
            if(selectedCurrencyTo == null)
            {
                MessageBox.Show("wybierz walute na którą chcesz zamienić");
            } 
        }

        private void zamien_Click(object sender, RoutedEventArgs e)
        {
            if (zamienz.Text != "") {
                int zamienZilosc = Convert.ToInt32(zamienz.Text);
                double zamienione = CurrencyCalculator.ConvertCurrency(zamienZilosc, selectedCurrencyfrom, selectedCurrencyTo);
                zamienna.Text = Math.Round(zamienione,2).ToString();
            } else
            {
                MessageBox.Show("Wpisz wartość !");
            }
            
        }
    }
}
