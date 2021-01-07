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
    public class rentaController
    {
        public async Task<FullRenta> obtenerPorId(int rentaId)
        {
            using (var db =  new videojuegos_db())
            {
                var detalles = await (from detalle in db.rentas_detalles.Where(r => r.renta_id == rentaId)
                                      join videojuego in db.videojuegos on detalle.videojuego_id equals videojuego.id
                                      select new RentaDetalle 
                                      {
                                          Cantidad = detalle.cantidad,
                                          Id = detalle.id,
                                          Importe = detalle.importe,
                                          RentaId = detalle.renta_id,
                                          Videojuego = videojuego.nombre,
                                          Estatus = (int)detalle.estatus
                                      }
                                      ).ToListAsync();
                var rentafromdb = await (from renta in db.rentas.Where(r => r.id == rentaId)
                                         join usuario in db.usuarios on renta.usuario_id equals usuario.id
                                         join cliente in db.clientes on renta.cliente_id equals cliente.id
                                         select new Renta
                                         {
                                             Id = renta.id,
                                             Cliente = cliente.nombre,
                                             Usuario = usuario.nombre_real,
                                             Fecha = (DateTime)renta.fecha,
                                             Estatus = (int)renta.estatus,
                                             Total = renta.total
                                         }
                                        ).FirstOrDefaultAsync();
                return new FullRenta(renta: rentafromdb, detalles: detalles);
            }
        }

        public async Task<List<FullRenta>> obtenerRentas(DateTime fromt, DateTime to)
        {
            using (var db = new videojuegos_db())
            {
                var detallesfromdb = await (from detalle in db.rentas_detalles
                                      join videojuego in db.videojuegos on detalle.videojuego_id equals videojuego.id
                                      join renta in db.rentas on detalle.renta_id equals renta.id
                                      where renta.fecha >= fromt && renta.fecha <= to
                                      select new RentaDetalle
                                      {
                                          Cantidad = detalle.cantidad,
                                          Id = detalle.id,
                                          Importe = detalle.importe,
                                          RentaId = detalle.renta_id,
                                          Videojuego = videojuego.nombre,
                                          Estatus = (int)detalle.estatus
                                      }
                                      ).ToListAsync();
                var rentafromdb = await (from renta in db.rentas
                                         join usuario in db.usuarios on renta.usuario_id equals usuario.id
                                         join cliente in db.clientes on renta.cliente_id equals cliente.id
                                         where renta.fecha >= fromt && renta.fecha <= to
                                         select new Renta
                                         {
                                             Id = renta.id,
                                             Cliente = cliente.nombre,
                                             Usuario = usuario.nombre_real,
                                             Fecha = (DateTime)renta.fecha,
                                             Estatus = (int)renta.estatus,
                                             Total = renta.total
                                         }
                                        ).ToListAsync();

                var listaDeRentas = rentafromdb.Select(renta =>
                    {
                        return new FullRenta(renta, detallesfromdb.Where(d =>
                            d.RentaId == renta.Id
                        ).ToList());
                    }
                );

                return listaDeRentas
                        .OrderByDescending(o => o.Renta.Id)
                        .Where(u => u.Renta.Estatus != 0)
                        .ToList();
            }
        }

        public async Task<List<FullRenta>> obtenerRentasPorCliente(DateTime fromt, DateTime to, int clienteId)
        {
            using (var db = new videojuegos_db())
            {
                var detallesfromdb = await (from detalle in db.rentas_detalles
                                      join videojuego in db.videojuegos on detalle.videojuego_id equals videojuego.id
                                      join renta in db.rentas on detalle.renta_id equals renta.id
                                      where renta.fecha >= fromt && renta.fecha <= to && renta.cliente_id == clienteId
                                      select new RentaDetalle
                                      {
                                          Cantidad = detalle.cantidad,
                                          Id = detalle.id,
                                          Importe = detalle.importe,
                                          RentaId = detalle.renta_id,
                                          Videojuego = videojuego.nombre,
                                          Estatus = (int)detalle.estatus
                                      }
                                      ).ToListAsync();
                var rentafromdb = await (from renta in db.rentas
                                         join usuario in db.usuarios on renta.usuario_id equals usuario.id
                                         join cliente in db.clientes on renta.cliente_id equals cliente.id
                                         where renta.fecha >= fromt && renta.fecha <= to && renta.cliente_id == clienteId
                                         select new Renta
                                         {
                                             Id = renta.id,
                                             Cliente = cliente.nombre,
                                             Usuario = usuario.nombre_real,
                                             Fecha = (DateTime)renta.fecha,
                                             Estatus = (int)renta.estatus,
                                             Total = renta.total
                                         }
                                        ).ToListAsync();

                var listaDeRentas = rentafromdb.Select(renta =>
                    new FullRenta(renta, detallesfromdb.Where(rd =>
                        rd.RentaId == renta.Id
                    ).ToList())
                );

                return listaDeRentas
                        .OrderByDescending(o => o.Renta.Id)
                        .Where(u => u.Renta.Estatus != 0)
                        .ToList();
            }
        }
        public async Task<List<FullRenta>> obtenerRentasPorUsuario(DateTime fromt, DateTime to, int usuarioId)
        {
            using (var db = new videojuegos_db())
            {
                var detallesfromdb = await (from detalle in db.rentas_detalles
                                      join videojuego in db.videojuegos on detalle.videojuego_id equals videojuego.id
                                      join renta in db.rentas on detalle.renta_id equals renta.id
                                      where renta.fecha >= fromt && renta.fecha <= to && renta.usuario_id == usuarioId
                                            select new RentaDetalle
                                      {
                                          Cantidad = detalle.cantidad,
                                          Id = detalle.id,
                                          Importe = detalle.importe,
                                          RentaId = detalle.renta_id,
                                          Videojuego = videojuego.nombre,
                                          Estatus = (int)detalle.estatus
                                      }
                                      ).ToListAsync();
                var rentafromdb = await (from renta in db.rentas
                                         join usuario in db.usuarios on renta.usuario_id equals usuario.id
                                         join cliente in db.clientes on renta.cliente_id equals cliente.id
                                         where renta.fecha >= fromt && renta.fecha <= to && renta.usuario_id == usuarioId
                                         select new Renta
                                         {
                                             Id = renta.id,
                                             Cliente = cliente.nombre,
                                             Usuario = usuario.nombre_real,
                                             Fecha = (DateTime)renta.fecha,
                                             Estatus = (int)renta.estatus,
                                             Total = renta.total
                                         }
                                        ).ToListAsync();

                var listaDeRentas = rentafromdb.Select(renta =>
                    new FullRenta(renta, detallesfromdb.Where(rd =>
                        rd.RentaId == renta.Id
                    ).ToList())
                );

                return listaDeRentas
                        .OrderByDescending(o => o.Renta.Id)
                        .Where(u => u.Renta.Estatus != 0)
                        .ToList();
            }
        }

        public async Task<FullRenta> crearNueva(rentas renta, List<rentas_detalles> detalle)
        {
            using (var db = new videojuegos_db())
            {
                var nuevaRenta = db.rentas.Add(renta);
                await db.SaveChangesAsync();
                // Se puede cambiar por un foreach funcional.
                var nuevaRentaD = db.rentas_detalles.AddRange(detalle.Select( d =>
                    {
                        d.renta_id = nuevaRenta.id;
                        return d;
                    }
                ));
                await db.SaveChangesAsync();
                return await obtenerPorId(nuevaRenta.id);
            }
        }

        public async Task<FullRenta> darDeBaja(int rentaId)
        {
            using (var db =  new videojuegos_db())
            {
                var renta = await db.rentas.FirstOrDefaultAsync(u =>
                    u.id == rentaId
                );
                renta.estatus = 0;
                await db.SaveChangesAsync();
                return await obtenerPorId(rentaId);
            }
        }
    }
}
