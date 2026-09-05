using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDALNT2.Models
{
    [Table("aluno")]
    public class Aluno
    {
        [Display(Name = "ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Nome: ")]
        [StringLength(35, ErrorMessage = "tamanho máximo 35 caracteres")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string nome { get; set; }

        [Display(Name = "Idade: ")]
        [Range(18, 120, ErrorMessage = "idade entre 18 e 120 anos")]
        public int idade { get; set; }

        //[Display(Name = "Curso: ")]
        //[StringLength(20, ErrorMessage = "tamanho máximo 20 caracteres")]
        //[Required(ErrorMessage = "Campo obrigatório")]
        //public string curso { get; set; }

        [Display(Name = "Curso")]
        public int cursoid { get; set; }

        [Display(Name = "Curso")]
        [ForeignKey("cursoid")]
        public virtual Curso curso { get; set; }

        [Display(Name = "Nota: ")]
        [Range(0, 10, ErrorMessage = "Valor nota tem que ser entre 0..10")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float nota { get; set; }
    }
}
