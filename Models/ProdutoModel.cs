using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDs.Models
{
    public class ProdutoModel
    {
        internal int quantidade;

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(500)]
        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public string Categoria {get; set;}
        public int Quantidade { get; set; }

    }
}