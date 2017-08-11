using System;
using System.Collections.Generic;
using mvvmApp.ViewModel;
using Xamarin.Forms;

namespace mvvmApp.Pages
{
    public partial class DeveloperPage : ContentPage
    {
        public DeveloperPage(DeveloperViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
