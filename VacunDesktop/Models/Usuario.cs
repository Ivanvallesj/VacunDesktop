using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VacunDesktop.Models
{
   public class Usuario: ModeloBase
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
    }
}
