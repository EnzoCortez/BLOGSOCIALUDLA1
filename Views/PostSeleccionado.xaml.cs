using BLOGSOCIALUDLA.Models;
using System.Collections.ObjectModel;

namespace BLOGSOCIALUDLA.Views
{
    public partial class PostSeleccionado : ContentPage
    {
        private Post _post;

        public ObservableCollection<Comentario> Comentarios { get; set; }

        public PostSeleccionado(Post post)
        {
            InitializeComponent();

            _post = post;
            tituloLabel.Text = post.Titulo;
            contenidoLabel.Text = post.Contenido;

            Comentarios = new ObservableCollection<Comentario>(post.Comentarios);
            comentariosCollectionView.ItemsSource = Comentarios;
             }

        private void EnviarComentario_Clicked(object sender, EventArgs e)
        {
            var nuevoComentario = new Comentario
            {
                Contenido = nuevoComentarioEntry.Text,
                Fecha = DateTime.Now
            };

            _post.Comentarios.Add(nuevoComentario);
            Comentarios.Add(nuevoComentario);

            nuevoComentarioEntry.Text = string.Empty;
        }
    }
}
