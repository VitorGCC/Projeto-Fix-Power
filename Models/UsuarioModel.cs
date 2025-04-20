using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDs.Models;
using ProjetoDs.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDs.Models
{
    public class UsuarioModel
    {
           public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Login { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        [Required]
        public PerfilEnum Perfil { get; set; }
        public Boolean SenhaValida(String senha)
        {
            return Senha == senha;
        }
    }
}