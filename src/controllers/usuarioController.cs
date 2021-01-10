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
        auditoriaController aCtrl = new auditoriaController();
        public async Task<usuarios> obtenerPorId(int usuarioId)
        {
            using (var db = new videojuegos_db())
            {
                var usuario = await db.usuarios.FirstOrDefaultAsync(u =>
                    u.id == usuarioId &&
                    u.estatus != 0
                );

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Verifico el usuario con id {usuarioId}.",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

                return usuario;
            }
        }

        public async Task<usuarios> verificarLogin(string usuario, string pass)
        {
            using (var db =  new videojuegos_db())
            {
                var user = await db.usuarios.FirstOrDefaultAsync(u =>
                   u.nombre == usuario &&
                   u.pass == pass &&
                   u.estatus != 0
                );

                string response = user != null ? "Aprobado" : "Denegado";
                await aCtrl.auditar(new auditorias
                {
                    accion = $"Acceso al sistema {response} para el empleado {usuario} ",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = 1
                });

                return user != null ? user : null;
            }
        }
        public async Task<usuarios> verificarNombre(string nombre)
        {
            using (var db =  new videojuegos_db())
            {
                var toVerify = await db.usuarios.FirstOrDefaultAsync(u =>
                    u.nombre == nombre &&
                    u.estatus != 0
                );

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Verifico el nombre de usuario {nombre}",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = 1
                });

                return toVerify != null ? toVerify : null; 
            }
        }

        public async Task<List<usuarios>> obtenerTodos()
        {
            using (var db = new videojuegos_db())
            {
                var users = await db.usuarios.Take(100).ToListAsync();

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Obtuvo todos los empleados.",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = 1
                });

                return users
                        .OrderByDescending( o => o.id)
                        .Where(u => u.estatus != 0)
                        .ToList();
            }
        }

        public async Task<usuarios> crearNuevo(usuarios nuevoUsuario)
        {
            using (var db = new videojuegos_db())
            {
                var usuario = db.usuarios.Add(nuevoUsuario);
                await db.SaveChangesAsync();

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Creo al usuario {usuario.nombre}",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

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

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Actualizo al usuario {usuario.nombre}",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

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

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Dio de baja al usuario con id {usuarioId}.",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

                return usuario;
            }
        }
    }
}
