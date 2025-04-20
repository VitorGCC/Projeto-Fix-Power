using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDs.Models
{
    public class LoginModel
    {
    [Required(ErrorMessage = "O endereço de e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "O formato do e-mail é inválido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "A senha é obrigatória.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Lembrar-me")]
    public bool RememberMe { get; set; }
         public Boolean SenhaValida(String senha)
        {
            return Senha == senha;
        }
    }
}