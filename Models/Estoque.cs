using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Estoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstoque { get; set; }

        [Required]
        public string CodigoProduto { get; set; }

        [Required]
        public int QtdProduto { get; set; }

        [Required]
        public DateTime DataProduto { get; set; }
    }
}
