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
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        private List<User> _usuarios;
        public List<User> Usuarios
        {
            get { return _usuarios; }
            set
            {
                _usuarios = value;
                OnPropertyChanged();
            }
        }

        public Command CerrarSesionCommand { get; }

        public UsuarioViewModel()
        {
            CerrarSesionCommand = new Command(CerrarSesion);
            LoadUsuarios();
        }

        private async void LoadUsuarios()
        {
            Usuarios = await App.BancoDatos.UsuarioDataTable.ListaUsuarios();
        }

        private async void CerrarSesion()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.LoginView());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
