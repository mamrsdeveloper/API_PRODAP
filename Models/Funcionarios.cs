using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Funcionarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuncionario { get; set; }


        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Cpf é obrigatório.")]        
        [MaxLength(14)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
        [MaxLength(100)]
        public string Email { get; set; }        
    }
}
