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
using static Filmek.Film;

namespace Filmek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Film> filmek = new List<Film>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void betoltes(object sender, RoutedEventArgs e)
        {
            filmek.Clear();

            filmek.Add(new Film("Csillagok háborúja", "sci-fi", 121, 8.6));
            filmek.Add(new Film("Titanic", "dráma", 195, 7.8));
            filmek.Add(new Film("A Gyűrűk ura", "fantasy", 201, 8.8));
            filmek.Add(new Film("Mátrix", "sci-fi", 136, 8.7));
            filmek.Add(new Film("Shrek", "animáció", 90, 7.9));

            dgFilmek.ItemsSource = null;
            dgFilmek.ItemsSource = filmek;
        }

        private void mennyi(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Filmek száma: " + filmek.Count);
        }

        private void leghosszabb(object sender, RoutedEventArgs e)
        {
            Film leghosszabb = filmek[0];

            foreach (Film f in filmek)
            {
                if (f.Hossz > leghosszabb.Hossz)
                {
                    leghosszabb = f;
                }
            }

            MessageBox.Show("A leghosszabb film: " + leghosszabb.Cim + " hHossz: " + leghosszabb.Hossz + " perc");
        }

        private void atlagErtek(object sender, RoutedEventArgs e)
        {
            double osszeg = 0;

            foreach(Film f in filmek)
            {
                osszeg += f.Ertekeles;
            }

            double atlag = osszeg / filmek.Count;
            MessageBox.Show("Átlagos értékelés: " + Math.Round(atlag, 2));
        }

        private void csakScifi(object sender, RoutedEventArgs e)
        {
            dgFilmek.ItemsSource = null;
            dgFilmek.ItemsSource = filmek.Where(f => f.Mufaj == "sci-fi").ToList();
        }

        private void csakCimek(object sender, RoutedEventArgs e)
        {
            List<FilmCim> cimek = new List<FilmCim>();

            foreach (Film f in filmek)
            {
                cimek.Add(new FilmCim(f.Cim));
            }
            dgFilmek.ItemsSource = null;
            dgFilmek.ItemsSource = cimek;
        }

        private void rendezes(object sender, RoutedEventArgs e)
        {
            dgFilmek.ItemsSource = null;
            dgFilmek.ItemsSource = filmek.OrderBy(f => f.Cim).ToList();
        }
    }
}