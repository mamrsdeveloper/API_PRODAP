using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Vendas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVendas { get; set; }

        [Required(ErrorMessage = "O campo funcionário é obrigatório.")]
        public int idFuncionario { get; set; }

        [Required(ErrorMessage = "O código do produto é obrigatório.")]
        [MaxLength(5)]
        public string CodigoProduto { get; set; }

        [Required(ErrorMessage = "Data da venda do produto é obrigatória.")]
        public DateTime DataHoraVenda { get; set; }

        [Required(ErrorMessage = "Quantidade do produto é obrigatório.")]
        public int QtdUnidadesVendidas { get; set; }
    }
}
