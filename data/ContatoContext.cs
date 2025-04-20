using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDs.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoDs.Data
{
    public class ContatoContext : DbContext
    {        
        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options){
        }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}