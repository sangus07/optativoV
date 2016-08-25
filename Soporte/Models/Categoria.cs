using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Soporte.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Display(Name ="Categoria")]
        public string Descripcion { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }

    }
}