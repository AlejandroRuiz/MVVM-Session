using System;
using System.Collections.Generic;
using mvvmApp.ViewModel;
using Xamarin.Forms;

namespace mvvmApp.Pages
{
    public partial class HomePage : ContentPage
    {
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
            var developer = e.Item as DeveloperViewModel;
            if(developer != null)
            {
                App.Current.MainPage.Navigation.PushAsync(new DeveloperPage(developer));
            }
        }

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
