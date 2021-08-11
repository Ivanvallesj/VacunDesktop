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
    public class DbAdminTutores : IDbAdmin
{
    public IEnumerable<object> ObtenerTodos()
    {
        using VacunWebContext db = new VacunWebContext();
        return db.Tutores.ToList();
    }

    public void Eliminar(int idSeleccionado)
    {
        using VacunWebContext db = new VacunWebContext();
        var tutor = db.Tutores.Find(idSeleccionado);
        //db.Tutores.Remove(Tutor);
        //REALIZAMOS TODA LA MECANICA PARA QUE MODIFIQUE EN LA BASE DE DATOS AL CALENDARIO
        tutor.Eliminado = true;
        tutor.FechaHoraEliminacion = DateTime.Now;
        tutor.Usuario = FrmMenuPrincipal.Usuario;
        db.Entry(tutor).State = EntityState.Modified;
        db.SaveChanges();

    }

    public object Obtener(int? idObtener)
    {
        //instanciamos un objeto DbContext
        using VacunWebContext db = new VacunWebContext();
        return db.Tutores.Find(idObtener);
    }

    public void Agregar(object tutor)
    {
        using VacunWebContext db = new VacunWebContext();
        db.Tutores.Add((Tutor)tutor);
        db.SaveChanges();
    }

    public void Actualizar(object tutor)
    {
        using VacunWebContext db = new VacunWebContext();
        db.Entry(tutor).State = EntityState.Modified;
        db.SaveChanges();
    }

    public IEnumerable<object> ObtenerTodos(string cadenaBuscada)
    {
        //instanciamos nuestro objeto db Context
        using VacunWebContext db = new VacunWebContext();
        //var listaTutores = from Tutor in db.Tutores
        //                       select new { Id = Tutor.Id, Nombre = Tutor.Nombre.Trim(), Sexo = Tutor.SexoPaciente };
        ////consultamos en el txtBusqueda si el nombre apellido o email contiene la expresion escrita en la grilla.
        //return listaTutores.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
        return db.Tutores.Where(c => c.Nombre.Contains(cadenaBuscada)).ToList();
    }

        IEnumerable<object> IDbAdmin.ObtenerEliminados()
        {
            throw new NotImplementedException();
        }
    }
}
