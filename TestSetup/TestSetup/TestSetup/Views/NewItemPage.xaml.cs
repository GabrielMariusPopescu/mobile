using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestSetup.Models;
using TestSetup.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSetup.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}