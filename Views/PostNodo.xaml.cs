// PostNodo.xaml.cs
using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using System.Collections.ObjectModel;
using BLOGSOCIALUDLA.Data;

namespace BLOGSOCIALUDLA.Views
{
    public partial class PostNodo : ContentPage
    {
        public ObservableCollection<Post> Posts { get; set; }

        public PostNodo()
        {
            InitializeComponent();
            Posts = new ObservableCollection<Post>(DataPostNodo.PostsNodo);
            BindingContext = this;
        }

        private async void PostPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPost = (sender as Picker)?.SelectedItem as Post;
            if (selectedPost != null)
            {
                await Navigation.PushAsync(new PostSeleccionado(selectedPost));
            }
        }

        private async void ClickPostNodo(object sender, EventArgs e)
        {
            var nuevaPage = new AddPostPage();
            nuevaPage.PostAgregado += NuevaPage_PostAgregado;
            await Navigation.PushAsync(nuevaPage);
        }

        private void NuevaPage_PostAgregado(object sender, Post e)
        {
            DataPostNodo.AgregarPostNodo(e);
            Posts.Add(e);
        }

        private async void Volver(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}