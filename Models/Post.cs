using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLOGSOCIALUDLA.Models;


namespace BLOGSOCIALUDLA.Models
{
    public class Post
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public  List<Comentario> Comentarios { get; set; } = new List<Comentario>();

    }
}
