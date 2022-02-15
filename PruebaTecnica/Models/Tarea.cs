using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnica.Models
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "EL Nombre de la tarea es Obligatorio")]
        [Display(Name ="Nombre De la Tarea")]
        public string NTarea { get; set; }
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "EL Estado es Obligatorio")]
        public bool Estado { get; set; }

        public string TiempoEstimado { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFinal { get; set; }
        [Required(ErrorMessage = "La prioridad es Obligatorio")]
        public int Prioridad { get; set; }

       
        [Required(ErrorMessage = "La Fecha Estimada es Obligatorio")]
        public DateTime FechaEstimado { get; set; }
       
     
      

    }




}
