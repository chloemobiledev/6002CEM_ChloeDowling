
using System;
using System.ComponentModel;
using YourKitchenApp.Models;
using System.Windows.Input;

namespace YourKitchenApp.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        private LoginRequestModel myloginRequestModel = new();
        public LoginRequestModel MyLoginRequestModel
        {
            get { return myloginRequestModel; }

            set
            {
                myloginRequestModel = value;
                OnPropertyChanged(nameof(MyLoginRequestModel));
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }


        public LoginPageViewModel()
        {
            LoginCommand = new Command(PerformLoginOperation);
            RegisterCommand = new Command(GoToRegisterForm);

        }

        public async void GoToRegisterForm(object obj)
        {
            await Shell.Current.GoToAsync(state: "//RegisterPage");
        }

        public async void PerformLoginOperation(object obj)
        {
            // perform api / db operation
            var data = MyLoginRequestModel;
            await Shell.Current.GoToAsync(state: "//MainPage");
        }


        public event PropertyChangedEventHandler PropertyChanged;
         
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
