using Microsoft.WindowsAzure.MobileServices;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using xPlatAuction.UWP.ViewModel;

namespace xPlatAuction.UWP
{
    public sealed partial class MainPage :Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnLoadItem_OnClick(object sender, RoutedEventArgs e)
        {
            Message.Text = "Loading items...";

            var client = new MobileServiceClient("http://localhost:58864/");

            var items = await client.GetTable<TodoItem>().ReadAsync();
            var item = items.First();
            Message.Text = item.Text;
        }
    }
}
