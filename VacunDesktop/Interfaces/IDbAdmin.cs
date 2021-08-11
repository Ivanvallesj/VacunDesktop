using System;
using System.Collections.Generic;
using System.Text;

namespace VacunDesktop.Interfaces
{
    public interface IDbAdmin
    {
        IEnumerable<object> ObtenerTodos();
        IEnumerable<object> ObtenerEliminados();
        IEnumerable<object> ObtenerTodos(string cadenaBuscada);
        void Eliminar(int idSeleccionado);
        object Obtener(int? idObtener);
        void Agregar(object Modelo);
        void Actualizar(object Modelo);
        

    }
}
