using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DataComentario
{
    public static Task<List<Comentario>> GetComentarios()
    {
        
        var comentarios = new List<Comentario>
        {
            new Comentario { Contenido = "¡La mejor de las facultades de la U! :)." },
            new Comentario { Contenido = "¿Cómo funciona el mentor virtual?." },
        };
        return Task.FromResult(comentarios);
    }
    
}
