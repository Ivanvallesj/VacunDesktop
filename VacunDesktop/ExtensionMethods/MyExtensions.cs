using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VacunDesktop.ExtensionMethods
{
    public static class MyExtensions
    {
        public static void OcultarColumnas(this DataGridView grid, bool ocultarMostrar = false)
        {
            if (grid.Columns["UsuarioId"] != null)
                grid.Columns["UsuarioId"].Visible = ocultarMostrar;
            if (grid.Columns["Usuario"] != null)
                grid.Columns["Usuario"].Visible = ocultarMostrar;
            if (grid.Columns["Eliminado"] != null)
                grid.Columns["Eliminado"].Visible = ocultarMostrar;
            if (grid.Columns["FechaHoraEliminacion"] != null)
                grid.Columns["FechaHoraEliminacion"].Visible = ocultarMostrar;
        }
        public static int ObtenerIdSeleccionado(this DataGridView grid)
        {
            return int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
