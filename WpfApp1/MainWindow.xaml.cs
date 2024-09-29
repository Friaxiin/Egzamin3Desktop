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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp1
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


        private void ImageChangePerson(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(personNumber.Text);

            //source images/000-zdjecie.jpg
            if (number == 000)
            {
                personImage.Source = new BitmapImage(new Uri("images/000-zdjecie.jpg", UriKind.RelativeOrAbsolute));
                fingerImage.Source = new BitmapImage(new Uri("images/000-odcisk.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (number == 111)
            {
                personImage.Source = new BitmapImage(new Uri("images/111-zdjecie.jpg", UriKind.RelativeOrAbsolute));
                fingerImage.Source = new BitmapImage(new Uri("images/111-odcisk.jpg", UriKind.RelativeOrAbsolute));

            }
            else if (number == 333)
            {
                personImage.Source = new BitmapImage(new Uri("images/333-zdjecie.jpg", UriKind.RelativeOrAbsolute));
                fingerImage.Source = new BitmapImage(new Uri("images/333-odcisk.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                personImage.Source = null;
                fingerImage.Source = null;
            }
        }

        /***************************************
         * 
         * nazwa funkcji:       DisplayAddedData
         * opis funkcji:        funkcja pobiera dane z pól edycyjnych oraz pola wyboru i przekazuje je do okienka z wiadomością zawierającą te dane
         * parametry:           brak
         * zwracany typ i opis: brak
         * autor:               Patryk Łabuz
         * 
         ***************************************/
        private void DisplayAddedData(object sender, RoutedEventArgs e)
        {
            //string pNumber = personNumber.Text;
            string pName = personName.Text;
            string pSurname = personSurname.Text;
            string eyeColor = "";

            if(blue.IsChecked == true)
            {
                eyeColor = "niebieskie";
            }
            else if (green.IsChecked == true)
            {
                eyeColor = "zielone";
            }
            else if (peony.IsChecked == true)
            {
                eyeColor = "piwne";
            }
            else
            {
                eyeColor = "nie wybrano";
            }

            string message = $"{pName} {pSurname} kolor oczu {eyeColor}";

            MessageBox.Show(message, "",MessageBoxButton.OK);
        }
    }
}