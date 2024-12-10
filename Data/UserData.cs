using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOGSOCIALUDLA.Models
{
    public class UserData
    {
        private SQLiteAsyncConnection _conexionDB;

        public UserData(SQLiteAsyncConnection conexionDB)
        {
            _conexionDB = conexionDB;
        }
        public Task<List<User>> ListaUsuarios()
        {
            var resultado = Task.FromResult(new List<User> { App.Usuario });


            var lista = _conexionDB
                .Table<User>()
                .ToListAsync();
            return resultado;
        }





        public Task<User> GetUsuario(string username, string password)
        {
            var usuario = _conexionDB.Table<User>().Where(x => x.Username == username && x.Password == password).FirstOrDefaultAsync();
            return usuario;
        }
        public Task<User> GetUsuario(Guid Id)
        {
            var usuario = _conexionDB
               .Table<User>().Where(x => x.Id == Id).FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> GuardarUsuario(User usuario)
        {

            var usuarioGuardado = await GetUsuario(usuario.Id);
            if (usuarioGuardado == null)
            {
                return await _conexionDB.InsertAsync(usuario);
            }
            else
            {
                return await _conexionDB.UpdateAsync(usuario);
            }

        }
        public async Task<int> EliminarUsuario(Guid id)
        {
            return await _conexionDB.DeleteAsync(id);
        }

        internal User GetUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
