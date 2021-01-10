using models.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllers
{
    public class videojuegoController
    {
        auditoriaController aCtrl = new auditoriaController();
        public async Task<videojuegos> obtenerPorId(int videojuegoId)
        {
            using (var db = new videojuegos_db())
            {
                var juego = await db.videojuegos.FirstOrDefaultAsync(u => 
                    u.id == videojuegoId
                );

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Busco por id al videojuego {juego.nombre}",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

                return juego;
            }
        }

        public async Task<videojuegos> verificarNombre(string nombre)
        {
            using (var db = new videojuegos_db())
            {
                var toVerify = await db.videojuegos.FirstOrDefaultAsync(u =>
                    u.nombre == nombre &&
                    u.estatus != 0
                );

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Verifico el videojuego {nombre}.",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

                return toVerify != null ? toVerify : null;
            }
        }

        public async Task<List<videojuegos>> obtenerTodos()
        {
            using (var db =  new videojuegos_db())
            {
                var juegos = await db.videojuegos.Take(100).ToListAsync();

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Obtuvo todos los videojuegos existentes",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

                return juegos
                        .OrderByDescending(o => o.id)
                        .Where(u => u.estatus != 0)
                        .ToList();
            }
        }

        public async Task<videojuegos> crearNuevo(videojuegos nuevoJuego)
        {
            using (var db =  new videojuegos_db())
            {
                var juego = db.videojuegos.Add(nuevoJuego);
                await db.SaveChangesAsync();

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Creo el videojuego {juego.nombre}",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });

                return juego;
            }
        }

        public async Task<videojuegos> editarJuego(videojuegos nuevoJuego)
        {
            using (var db =  new videojuegos_db())
            {
                var toUpdate = await db.videojuegos.FirstAsync(u =>
                    u.id == nuevoJuego.id
                );
                toUpdate.nombre = nuevoJuego.nombre;
                await db.SaveChangesAsync();

                await aCtrl.auditar(new auditorias
                {
                    accion = $"Edito el videojuego {toUpdate.nombre}",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });
                return toUpdate;
            }
        }

        public async Task<videojuegos> darDeBaja(int juegoId)
        {
            using (var db = new videojuegos_db())
            {
                var toUpdate = await db.videojuegos.FirstAsync(u =>
                    u.id == juegoId
                );
                toUpdate.estatus = 0;
                await db.SaveChangesAsync();
                await aCtrl.auditar(new auditorias
                {
                    accion = $"Dio de baja el videojuego con Id {juegoId}",
                    fecha = Convert.ToDateTime(DateTime.Now.ToString("d")),
                    estatus = 1,
                    usuario_id = globals.usuario.id
                });
                return toUpdate;
            }
        }
    }
}
