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
        public async Task<videojuegos> obtenerPorId(int videojuegoId)
        {
            using (var db = new videojuegos_db())
            {
                var juego = await db.videojuegos.FirstOrDefaultAsync(u => 
                    u.id == videojuegoId
                );
                return juego;
            }
        }

        public async Task<Boolean> verificarNombre(string nombre)
        {
            using (var db = new videojuegos_db())
            {
                var toVerify = await db.videojuegos.FirstAsync(u =>
                    u.nombre == nombre
                );
                return toVerify != null ? true : false;
            }
        }

        public async Task<List<videojuegos>> obtenerTodos()
        {
            using (var db =  new videojuegos_db())
            {
                var juegos = await db.videojuegos.Take(100).ToListAsync();
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
                return toUpdate;
            }
        }
    }
}
