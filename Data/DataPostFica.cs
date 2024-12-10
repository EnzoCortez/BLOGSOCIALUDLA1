using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Data
{
    public static class DataPostFica
    {
        private static List<Post> _postsFica = new List<Post>();

        public static List<Post> PostsFica
        {
            get { return _postsFica; }
        }

        public static void AgregarPostFica(Post nuevoPost)
        {
            _postsFica.Add(nuevoPost);
        }
    }
}
