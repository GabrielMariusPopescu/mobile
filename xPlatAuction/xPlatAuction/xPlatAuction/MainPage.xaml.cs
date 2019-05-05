using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Linq;

namespace xPlatAuction
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Title.Text = "Loading items...";
            var client = new MobileServiceClient("http://localhost:58864/");
            var items = await client.GetTable<TodoItem>().ReadAsync();
            var first = items.First();
            Title.Text = first.Text;
        }
    }
}
