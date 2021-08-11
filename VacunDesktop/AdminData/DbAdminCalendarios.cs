using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VacunDesktop.Interfaces;
using VacunDesktop.Models;
using VacunDesktop.Presentation;

namespace VacunDesktop.AdminData
{
   public class DbAdminCalendarios: IDbAdmin
    {
        public IEnumerable<object> ObtenerTodos()
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Calendarios.ToList();
        }

        public void Eliminar(int idSeleccionado)
        {
            using VacunWebContext db = new VacunWebContext();
                var calendario = db.Calendarios.Find(idSeleccionado);
                //db.Calendarios.Remove(Calendario);
                //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
                calendario.Eliminado = true;
                calendario.FechaHoraEliminacion = DateTime.Now;
                calendario.Usuario = FrmMenuPrincipal.Usuario;
                db.Entry(calendario).State = EntityState.Modified;
                db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using VacunWebContext db = new VacunWebContext();
            return db.Calendarios.Find(idObtener);
        }

        public void Agregar (object calendario)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Calendarios.Add((Calendario)calendario);
            db.SaveChanges();
        }

        public void Actualizar(object calendario)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Entry(calendario).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using VacunWebContext db = new VacunWebContext();
                //var listaCalendarios = from Calendario in db.Calendarios
                //                       select new { Id = Calendario.Id, Nombre = Calendario.Nombre.Trim(), Sexo = Calendario.SexoPaciente };
                ////consultamos en el txtBusqueda si el nombre apellido o email contiene la expresion escrita en la grilla.
                //return listaCalendarios.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
            return db.Calendarios.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
        }

        public IEnumerable<object> ObtenerEliminados()
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Calendarios.IgnoreQueryFilters().Where(c => c.Eliminado == true).ToList();
        }
    }
}
