using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial1
{
    public class Recursos 
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
        public Usuarios Usuario { get; set; }

    }
    
}
