using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Views
{
    public partial class AddPostPage : ContentPage
    {
        public event EventHandler<Post> PostAgregado;

        public AddPostPage()
        {
            InitializeComponent();
        }

        private async void ClickA�adirPost(object sender, EventArgs e)
        {
            string titulo = TituloPost.Text;    
                
            string contenido = ContenidoPost.Text;
            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(contenido))
            {
                await DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }
            var newPost = new Post
            {
                Titulo = titulo,
                Contenido = contenido
            };

            PostAgregado?.Invoke(this, newPost);

            await DisplayAlert("Post a�adido", "Tu post ha sido a�adido exitosamente.", "OK");
            await Navigation.PopAsync();
        }
    }
}
