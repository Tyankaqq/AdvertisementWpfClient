using AdvertisementWpfClient.Services;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Windows;

namespace AdvertisementWpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ApiService ApiService { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000/")
            };
            ApiService = new ApiService(httpClient);
        }
    }

}
