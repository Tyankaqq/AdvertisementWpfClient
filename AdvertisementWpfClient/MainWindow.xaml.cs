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

namespace AdvertisementWpfClient
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
        private async void GetAverageCost_Click(object sender, RoutedEventArgs e)
        {
            var averageCost = await App.ApiService.GetAverageCostAsync();
            ResultTextBlock.Text = $"Average Cost: {averageCost}";
        }

        private async void GetAdvertisementsAboveCost_Click(object sender, RoutedEventArgs e)
        {
            var cost = 50000m; // Пример значения
            var advertisements = await App.ApiService.GetAdvertisementsAboveCostAsync(cost);
            ResultTextBlock.Text = $"Advertisements Above Cost: {advertisements.Count}";
        }

        private async void GetMostPopularBroadcasts_Click(object sender, RoutedEventArgs e)
        {
            var broadcasts = await App.ApiService.GetMostPopularBroadcastsAsync();
            ResultTextBlock.Text = $"Most Popular Broadcasts: {broadcasts.Count}";
        }
    }
}