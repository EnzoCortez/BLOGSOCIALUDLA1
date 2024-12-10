using BLOGSOCIALUDLA.Data;
using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.ViewModels;

//using BLOGSOCIALUDLA.Models.BLOGSOCIALUDLA.Models;
using Microsoft.Maui.Controls;
using System;
using System.Linq;

namespace BLOGSOCIALUDLA.Views
{
    public partial class UsuarioView : ContentPage
    {
        public List<User> Usuarios { get; set; }
     

        public UsuarioView()
        {
            InitializeComponent();
            BindingContext = new UsuarioViewModel();

  
            
        }

       
    }
}
