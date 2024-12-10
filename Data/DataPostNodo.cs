using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Data
{
    public static class DataPostNodo
    {
        private static List<Post> _postsNodo = new List<Post>();

        public static List<Post> PostsNodo
        {
            get { return _postsNodo; }
        }

        public static void AgregarPostNodo(Post nuevoPost)
        {
            _postsNodo.Add(nuevoPost);
        }
    }
}


