using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class Estados_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_estados_equipo { get; set; }

        [Display(Name ="Descripción")]
        public string descripcion { get; set; }

        [Display(Name ="Estado")]
        public string estado { get; set; }
    }
}
