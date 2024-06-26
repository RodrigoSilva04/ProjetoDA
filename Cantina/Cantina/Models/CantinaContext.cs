﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GereCantina.Models
{
    
    
        public class CantinaContext : DbContext
        {
        public CantinaContext() : base("name=CantinaContext")
        {
            }

            public DbSet<Utilizador> Utilizadores { get; set; }
            public DbSet<Funcionario> Funcionarios { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Estudante> Estudantes { get; set; }
            public DbSet<Professor> Professores { get; set; }
            public DbSet<Multa> Multas { get; set; }
            public DbSet<Reserva> Reservas { get; set; }
            public DbSet<Prato> Pratos { get; set; }
            public DbSet<Extra> Extras { get; set; }
            public DbSet<Menu> Menus { get; set; }
            public DbSet<Fatura> Faturas { get; set; }
            public DbSet<ItemFatura> ItensFatura { get; set; }

            
    }

    
}
