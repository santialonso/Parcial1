using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial1
{
    class Tareas 
    {
        
        public Tareas() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Titulo { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
        public DateTime Vencimiento  { get; set; }
        public int Estimacion { get; set; }
        public string Responsable { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
        public Boolean Estado { get; set; }
        

    }
}
