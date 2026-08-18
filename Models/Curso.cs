using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUDALNT2.Models
{
    [Table("curso")]
    public class Curso
    {
        [Display(Name ="ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name ="Descrição: ")]
        [StringLength(25 ,ErrorMessage = "Campo no máximo 25 caracteres")]
        [Required(ErrorMessage ="campo não pode ser nulo....")]
        public string descricao { get; set; }   
        
        [Display(Name ="Área: ")]
        [StringLength(12 ,ErrorMessage = "Campo no máximo 12 caracteres")]
        [Required(ErrorMessage ="campo não pode ser nulo....")]
        public string area { get; set; }
        
        [Display(Name ="Sigla: ")]
        [StringLength(3 ,ErrorMessage = "Campo no máximo 3 caracteres")]
        [Required(ErrorMessage ="campo não pode ser nulo....")]
        public string sigla { get; set; }
    }
}