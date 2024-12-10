using BLOGSOCIALUDLA.Models;
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
    public class RegistroUsuarioViewModel: INotifyPropertyChanged
    {
        private User _usuario;
        public User Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
                OnPropertyChanged();
            }
        }
        //comandos para el uso de los botones:
        public Command RegistrarseCommand { get; }
        public Command InicioSesionCommand { get; }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        public RegistroUsuarioViewModel()
        {
            _usuario = new User();
            RegistrarseCommand = new Command(async () => await ClickRegistrarse());
            InicioSesionCommand = new Command(ClickInicioSesionRegistro);
        }
        private async Task ClickRegistrarse()
        {
            if (string.IsNullOrWhiteSpace(Usuario.Username) && string.IsNullOrEmpty(Usuario.Password) && string.IsNullOrWhiteSpace(Usuario.Nombre) && string.IsNullOrWhiteSpace(Usuario.Apellido))
            {
                await Application.Current.MainPage.DisplayAlert("Atención", "Llena toda la información", "Ok");
                return;
            }

            var registro = await App.BancoDatos.UsuarioDataTable.GuardarUsuario(Usuario);
            if (registro > 0)
            {
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }
        

        private async void ClickInicioSesionRegistro()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InicioSesion());
        }

         


    }
}
