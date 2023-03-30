using System.ComponentModel.DataAnnotations;
namespace PracticaMVC.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int facultad_id { get; set; }

        [Display(Name = "Nombre de la facultad")]
        public int nombre_facultad { get; set; }
    }
}
