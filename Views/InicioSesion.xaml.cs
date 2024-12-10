using Microsoft.Maui.Controls;
using System;
using System.Linq;
using BLOGSOCIALUDLA.Data;
using BLOGSOCIALUDLA.ViewModels;
//using BLOGSOCIALUDLA.Models.BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Views
{
    public partial class InicioSesion : ContentPage
    {
        public InicioSesion()

        {
            BindingContext = new InicioSesionViewModel();

            InitializeComponent();
        }
        
    }
}
