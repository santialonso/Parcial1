using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial1
{
   public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsuarioPK { get; set; }

        [MaxLength(50)]
        [MinLength(10)]
        public string Nombre { get; set; }
        
        [Required]
        [Column("Password", TypeName ="char(20)")]
        public string Clave { get; set; }
       


    }
}
