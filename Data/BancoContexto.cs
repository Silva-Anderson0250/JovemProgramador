﻿using JovemProgramador.Data.Mapeamento;
using JovemProgramador.Models;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramador.Data
{


    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }

    }

    
}
