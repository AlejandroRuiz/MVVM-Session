using System;
using System.Collections.ObjectModel;
using mvvmApp.Pages;
using Xamarin.Forms;

namespace mvvmApp.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Developers = new ObservableCollection<DeveloperViewModel>(){
                new DeveloperViewModel(new Model.Developer(){Name ="Alejandro", LastName="Ruiz", HasBook=false}),
                new DeveloperViewModel(new Model.Developer(){Name ="Jose", LastName="Perez", HasBook=true})
            };
            AddDeveloperCommand = new Command(InvokeAddDeveloperCommand);
            DeleteDeveloperCommand = new Command<DeveloperViewModel>(InvokeDeleteDeveloperCommand);
        }

        public ObservableCollection<DeveloperViewModel> Developers { get; }

        public Command AddDeveloperCommand { get; }

        public Command<DeveloperViewModel> DeleteDeveloperCommand { get; }

        void InvokeAddDeveloperCommand()
        {
            var newDeveloper = new DeveloperViewModel();
            Developers.Add(newDeveloper);
            App.Current.MainPage.Navigation.PushAsync(new DeveloperPage(newDeveloper));
        }

        void InvokeDeleteDeveloperCommand(DeveloperViewModel developer)
		{
            Developers.Remove(developer);
		}
    }
}
