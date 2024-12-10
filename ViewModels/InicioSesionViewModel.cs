using BLOGSOCIALUDLA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.ViewModels
{
    public class InicioSesionViewModel : INotifyPropertyChanged
    {
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public InicioSesionViewModel()
        {
            IniciarSesionCommand = new Command(async () => await IniciarSesion());
            RegistroCommand = new Command(NavegarRegistro);

        }

        public Command IniciarSesionCommand { get; }
        public Command RegistroCommand { get; }

        private async Task IniciarSesion()
        {
            if (!string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password))
            {
                var usuario = await App.BancoDatos.UsuarioDataTable.GetUsuario(Username, Password);
                if (usuario == null)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Username o contraseña inválidos", "Ok");
                    return;
                }
                App.Usuario = usuario;
                await Application.Current.MainPage.Navigation.PushAsync(new PaginaPrincipal());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, ingrese su email y contraseña.", "Ok");
            }
        }
        private async void NavegarRegistro()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RegistroUsuario());
        }

         
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
