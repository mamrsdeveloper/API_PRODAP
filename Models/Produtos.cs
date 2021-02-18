using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Produtos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "O campo código é obrigatório.")]
        [StringLength(5, ErrorMessage = "O código deve conter 5 caracteres.", MinimumLength = 5)]
        public string CodigoProduto { get; set; }

        [Required(ErrorMessage = "O campo Marca é obrigatório.")]
        [StringLength(50)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Validade é obrigatório.")]
        [StringLength(50)]
        public int Validade { get; set; }
    }
}
