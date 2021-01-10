using models;
using models.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controllers
{
    public class inventarioController
    {
        public async Task<Inventario> obtenerPorId(int inventarioId)
        {
            using (var db = new videojuegos_db())
            {
                var inv = await (from inventario in db.inventarios
                                 join videojuego in db.videojuegos on inventario.videojuego_id equals videojuego.id
                                 where inventario.id == inventarioId && videojuego.estatus != 0
                                 select new Inventario
                                 {
                                     Id = inventario.id,
                                     Videojuego = videojuego.nombre,
                                     Existencias = inventario.existencias,
                                     Estatus = (int)inventario.estatus
                                 }).FirstOrDefaultAsync();
                return inv;
            }
        }

        public async Task<Inventario> crearNuevo(inventarios inventario)
        {
            using (var db = new videojuegos_db())
            {
                var newInv = db.inventarios.Add(inventario);
                await db.SaveChangesAsync();
                return await obtenerPorId(newInv.id);
            }
        }

        public async Task<Inventario> agregarExistencias(int videojuegoId, int existencias)
        {
            using (var db = new videojuegos_db())
            {
                var inventario = await db.inventarios.FirstOrDefaultAsync(i =>
                    i.videojuego_id == videojuegoId
                );
                inventario.existencias += existencias;
                await db.SaveChangesAsync();
                return await obtenerPorId(inventario.id);
            }
        }

        public async Task<Inventario> disminuirExistencias(int videojuegoId, int existencias)
        {
            using (var db = new videojuegos_db())
            {
                var inventario = await db.inventarios.FirstOrDefaultAsync(i =>
                    i.videojuego_id == videojuegoId
                );
                inventario.existencias -= existencias;
                await db.SaveChangesAsync();
                return await obtenerPorId(inventario.id);
            }
        }

        public async Task<List<Inventario>> obtenerTodos()
        {
            using (var db = new videojuegos_db())
            {
                var inventarios = await (from inv in db.inventarios
                                         join videojuego in db.videojuegos on inv.videojuego_id equals videojuego.id
                                         where videojuego.estatus != 0
                                         select new Inventario
                                         {
                                             Id = inv.id,
                                             Videojuego = videojuego.nombre,
                                             Existencias = inv.existencias,
                                             Estatus = (int)inv.estatus
                                         }).ToListAsync();
                return inventarios
                        .OrderByDescending(o => o.Id)
                        .Where(u => u.Estatus != 0)
                        .ToList();
            }
        }

        public async Task<List<Inventario>> obtenerAgotados()
        {
            using (var db = new videojuegos_db())
            {
                var inventarios = await (from inv in db.inventarios
                                         join videojuego in db.videojuegos on inv.videojuego_id equals videojuego.id
                                         where inv.existencias == 0 && videojuego.estatus != 0
                                         select new Inventario
                                         {
                                             Id = inv.id,
                                             Videojuego = videojuego.nombre,
                                             Existencias = inv.existencias,
                                             Estatus = (int)inv.estatus
                                         }).ToListAsync();
                return inventarios
                        .OrderByDescending(o => o.Id)
                        .Where(u => u.Estatus != 0)
                        .ToList();
            }
        }
        public async Task<List<Inventario>> obtenerPorAgotar()
        {
            using (var db = new videojuegos_db())
            {
                var inventarios = await (from inv in db.inventarios
                                         join videojuego in db.videojuegos on inv.videojuego_id equals videojuego.id
                                         where inv.existencias <= 2 &&  inv.existencias !=0 && videojuego.estatus != 0
                                         select new Inventario
                                         {
                                             Id = inv.id,
                                             Videojuego = videojuego.nombre,
                                             Existencias = inv.existencias,
                                             Estatus = (int)inv.estatus
                                         }).ToListAsync();
                return inventarios
                        .OrderByDescending(o => o.Id)
                        .Where(u => u.Estatus != 0)
                        .ToList();
            }
        }
    }
}
