using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class SaidaVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSaidaVenda { get; set; }

        public int idFuncionario { get; set; }

        public string CodigoProduto { get; set; }

        public Int32 QtdQuantidadeRetirada { get; set; }

    }
}
