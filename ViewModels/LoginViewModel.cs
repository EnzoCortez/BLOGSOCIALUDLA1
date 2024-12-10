using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BLOGSOCIALUDLA.ViewModels
{
   public class LoginViewModel: INotifyPropertyChanged
    {
        public ICommand NavigateToLoginCommand { get; }
        public ICommand NavigateToRegisterCommand { get; }


        public LoginViewModel()
        {
            NavigateToLoginCommand = new Command(NavigateToLogin);
            NavigateToRegisterCommand = new Command(NavigateToRegister);
        }

        private async void NavigateToLogin()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.InicioSesion());
        }

        private async void NavigateToRegister()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.RegistroUsuario());
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
