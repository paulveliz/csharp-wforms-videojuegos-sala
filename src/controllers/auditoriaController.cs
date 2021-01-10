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
    public class auditoriaController
    {
        public async Task<auditorias> auditar(auditorias auditoria)
        {
            using (var db = new videojuegos_db())
            {
                db.auditorias.Add(auditoria);
                await db.SaveChangesAsync();
                return auditoria;
            }
        }

        public async Task<bool> depurar()
        {
            using (var db = new videojuegos_db())
            {
                var allAudits = await (from c in db.auditorias select c).ToListAsync();
                db.auditorias.RemoveRange(allAudits);
                var rows = await db.SaveChangesAsync();
                return rows > 0;
            }
        }

        public async Task<List<Auditoria>> obtenerAuditoriasPorFecha(DateTime fromt, DateTime to)
        {
            using (var db = new videojuegos_db())
            {
                var auditorias = await (from auditoria in db.auditorias
                                          join usuario in db.usuarios on auditoria.usuario_id equals usuario.id
                                        where auditoria.fecha >= fromt && auditoria.fecha <= to
                                          select new Auditoria
                                          {
                                            Id = auditoria.id,
                                            Accion = auditoria.accion,
                                            Estatus = (int)auditoria.estatus,
                                            Usuario = usuario.nombre,
                                            Fecha = auditoria.fecha
                                          }
                                  ).ToListAsync();
                return auditorias;
            }
        }

        public async Task<List<Auditoria>> obtenerAuditoriasPorUsuario(int usuarioId, DateTime fromt, DateTime to)
        {
            using (var db = new videojuegos_db())
            {
                var auditorias = await (from auditoria in db.auditorias
                                        join usuario in db.usuarios on auditoria.usuario_id equals usuario.id
                                        where 
                                        auditoria.fecha >= fromt && 
                                        auditoria.fecha <= to &&
                                        usuario.id == usuarioId
                                        select new Auditoria
                                        {
                                            Id = auditoria.id,
                                            Accion = auditoria.accion,
                                            Estatus = (int)auditoria.estatus,
                                            Usuario = usuario.nombre,
                                            Fecha = auditoria.fecha
                                        }
                                  ).ToListAsync();
                return auditorias;
            }
        }
    }
}
