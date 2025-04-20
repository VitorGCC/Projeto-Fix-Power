using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDs.Models;

namespace ProjetoDs.Repository
{
    public interface IUsuarioRepository
    {
        UsuarioModel BuscarPorEmail(string login);
        UsuarioModel adicionar(UsuarioModel usuario);
    }
}