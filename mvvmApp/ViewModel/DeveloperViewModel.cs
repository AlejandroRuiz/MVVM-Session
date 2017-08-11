using System;
using mvvmApp.Model;
using Xamarin.Forms;

namespace mvvmApp.ViewModel
{
    public class DeveloperViewModel : BaseViewModel
    {
        public Developer Developer { get; }

        public DeveloperViewModel(Developer developer = null)
        {
            Developer = developer ?? new Developer();
            SaveCommand = new Command(InvokeSaveCommand);
        }

		public string Name
        {
            get
            {
                return Developer.Name;
            }
            set
            {
                Developer.Name = value;
                OnPropertyChanged();
            }
        }

		public string LastName
        {
            get
            {
                return Developer.LastName;
            }
            set
            {
                Developer.LastName = value;
                OnPropertyChanged();
            }
        }

		public bool HasBook
        {
			get
			{
                return Developer.HasBook;
			}
			set
			{
                Developer.HasBook = value;
				OnPropertyChanged();
                OnPropertyChanged(nameof(LineColor));
			}  
        }

        public Color LineColor => (HasBook) ? Color.Green : Color.Red;

        public Command SaveCommand { get; }

        void InvokeSaveCommand()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
