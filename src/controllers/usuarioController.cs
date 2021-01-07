using models.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllers
{
    public class usuarioController
    {
        public async Task<usuarios> obtenerPorId(int usuarioId)
        {
            using (var db = new videojuegos_db())
            {
                var usuario = await db.usuarios.FirstOrDefaultAsync(u =>
                    u.id == usuarioId
                );
                return usuario;
            }
        }

        public async Task<usuarios> verificarLogin(string usuario, string pass)
        {
            using (var db =  new videojuegos_db())
            {
                var user = await db.usuarios.FirstOrDefaultAsync(u =>
                   u.nombre == usuario &&
                   u.pass == pass
                );

                return user != null ? user : null;
            }
        }
        public async Task<bool> verificarNombre(string nombre)
        {
            using (var db =  new videojuegos_db())
            {
                var toVerify = await db.usuarios.FirstOrDefaultAsync(u =>
                    u.nombre == nombre
                );
                return toVerify != null ? true : false; 
            }
        }

        public async Task<List<usuarios>> obtenerTodos()
        {
            using (var db = new videojuegos_db())
            {
                var users = await db.usuarios.Take(100).ToListAsync();
                return users;
            }
        }

        public async Task<usuarios> crearNuevo(usuarios nuevoUsuario)
        {
            using (var db = new videojuegos_db())
            {
                var usuario = db.usuarios.Add(nuevoUsuario);
                await db.SaveChangesAsync();
                return usuario;
            }
        }

        public async Task<usuarios> actualizar(usuarios usuarioActualizado)
        {
            using (var db =  new videojuegos_db())
            {
                var usuario = await db.usuarios.FirstOrDefaultAsync(u => 
                    u.id == usuarioActualizado.id
                );
                usuario.nombre = usuarioActualizado.nombre;
                usuario.nombre_real = usuarioActualizado.nombre_real;
                usuario.pass = usuarioActualizado.pass;
                await db.SaveChangesAsync();
                return usuario;
            }
        }

        public async Task<usuarios> darDeBaja(int usuarioId)
        {
            using (var db = new videojuegos_db())
            {
                var usuario = await db.usuarios.FirstOrDefaultAsync(u =>
                    u.id == usuarioId
                );
                usuario.estatus = 0;
                await db.SaveChangesAsync();
                return usuario;
            }
        }
    }
}
