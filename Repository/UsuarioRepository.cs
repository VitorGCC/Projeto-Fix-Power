using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDs.Data;
using ProjetoDs.Models;

namespace ProjetoDs.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ContatoContext contato_Context;

        public UsuarioRepository(ContatoContext contatoContext){
            contato_Context = contatoContext;
        }
        public UsuarioModel adicionar(UsuarioModel usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            contato_Context.Usuarios.Add(usuario);
            contato_Context.SaveChanges();
            return usuario;
        }
          public UsuarioModel BuscarPorEmail(string email)
        {
            return contato_Context.Usuarios.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }
        
    }
}