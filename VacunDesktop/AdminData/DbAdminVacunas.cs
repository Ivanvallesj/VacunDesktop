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
    public class DbAdminVacunas : IDbAdmin
    {
        public IEnumerable<object> ObtenerTodos()
        {
            using VacunWebContext db = new VacunWebContext();
            return db.Vacunas.ToList();
        }

        public void Eliminar(int idSeleccionado)
        {
            using VacunWebContext db = new VacunWebContext();
            var vacuna = db.Vacunas.Find(idSeleccionado);
            //db.Vacunas.Remove(Vacuna);
            //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
            vacuna.Eliminado = true;
            vacuna.FechaHoraEliminacion = DateTime.Now;
            vacuna.Usuario = FrmMenuPrincipal.Usuario;
            db.Entry(vacuna).State = EntityState.Modified;
            db.SaveChanges();

        }

        public object Obtener(int? idObtener)
        {
            //instanciamos un objeto DbContext
            using VacunWebContext db = new VacunWebContext();
            return db.Vacunas.Find(idObtener);
        }

        public void Agregar(object vacuna)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Vacunas.Add((Vacuna)vacuna);
            db.SaveChanges();
        }

        public void Actualizar(object vacuna)
        {
            using VacunWebContext db = new VacunWebContext();
            db.Entry(vacuna).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
        {
            //instanciamos nuestro objeto db Context
            using VacunWebContext db = new VacunWebContext();
            //var listaVacunas = from Vacuna in db.Vacunas
            //                       select new { Id = Vacuna.Id, Nombre = Vacuna.Nombre.Trim(), Sexo = Vacuna.SexoPaciente };
            ////consultamos en el txtBusqueda si el nombre apellido o email contiene la expresion escrita en la grilla.
            //return listaVacunas.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
            return db.Vacunas.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
        }

        IEnumerable<object> IDbAdmin.ObtenerEliminados()
        {
            throw new NotImplementedException();
        }
    }
}
