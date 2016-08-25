using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Soporte.Models
{
    [Table("Cliente")]

    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage =" Ingrese {0}")]
        [StringLength(100, ErrorMessage = " El campo {0} debe tener entre {1} y {2} caracteres", MinimumLength = 3)]
         public string RazonSocial { get; set; }
        [Required(ErrorMessage = " Ingrese {0}")]
        [StringLength(20, ErrorMessage = " El campo {0} debe tener entre {1} y {2} caracteres", MinimumLength = 3)]
        public string Ruc { get; set; }
        
        [StringLength(20)]
         public string Celular { get; set; }
                [Required(ErrorMessage = " Ingrese {0}")]
        [StringLength(200, ErrorMessage = " El campo {0} debe tener entre {1} y {2} caracteres", MinimumLength = 3)]

        public string Direccion { get; set; }
        [Required(ErrorMessage = " Ingrese {0}")]
        [StringLength(20, ErrorMessage = " El campo {0} debe tener entre {1} y {2} caracteres", MinimumLength = 3)]
        public string Telefono { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreado { get; set; }

        public string CreadoPor { get; set; }
         
        public virtual Categoria Categoria { get; set; }
        [Display(Name ="Categoria")]
        public int IdCategoria { get; set; }

    }
}