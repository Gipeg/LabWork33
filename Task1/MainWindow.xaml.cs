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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new List<Game>
            {
                new Game { IdGame = 1, Name = "Смута", Site = "Smuta.Com", Category = "RPG", Price = 2000 },
                new Game { IdGame = 2, Name = "Atomic Heater", Site = "Steam", Category = "Shooter", Price = 1500 },
                new Game { IdGame = 3, Name = "Дурак", Site = "Яндекс Игры", Category = "table", Price = 0 },
                new Game { IdGame = 4, Name = "Terraria", Site = "Steam", Category = "RPG", Price = 300 },
                new Game { IdGame = 5, Name = "kkk", Site = "kkk", Category = "kkk", Price = 111 }
            };

            GamesListView.ItemsSource = games;
        }
    }
}