using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using System;
using BLOGSOCIALUDLA.Data;
using BLOGSOCIALUDLA.ViewModels;
//using BLOGSOCIALUDLA.Models.BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Views
{
    public partial class RegistroUsuario : ContentPage
    {
    
        public RegistroUsuario()
        {
            InitializeComponent();
            BindingContext = new RegistroUsuarioViewModel();          
           
        }


    }
}
