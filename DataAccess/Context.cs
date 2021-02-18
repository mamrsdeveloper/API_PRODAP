using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Context : DbContext
    {


        public Context(DbContextOptions<Context> options)
         : base(options)
        { }

        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Vendas> Vendas { get; set; }
        public DbSet<SaidaVenda> saidaVendas { get; set; }
    }
}
