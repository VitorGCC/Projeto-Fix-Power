using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDs.Models
{
    using System.ComponentModel.DataAnnotations;

public class ResetSenhaViewModel
{
    [Required(ErrorMessage = "O endereço de e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "O formato do e-mail é inválido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "A nova senha é obrigatória.")]
    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
    public string NovaSenha { get; set; }

    [Required(ErrorMessage = "A confirmação da nova senha é obrigatória.")]
    [DataType(DataType.Password)]
    [Compare("NewPassword", ErrorMessage = "As senhas não coincidem.")]
    public string ConfirmeNovaSenha { get; set; }
}

}