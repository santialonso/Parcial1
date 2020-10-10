using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial1
{
    public class Detalles 


    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Fecha { get; set; }

        public string Tiempo { get; set; }
        public string Recurso { get; set; }
    }
}
