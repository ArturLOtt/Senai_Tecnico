using InLock.CodeFirst.WebApi.Manha.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InLock.CodeFirst.WebApi.Manha.Context
{
    public class InLockContext :  DbContext
    {

        //Jogos
        public DbSet<JogoDomain> Jogos { get; set; }

        //Estudios
        public DbSet<EstudioDomain> Estudio { get; set; }

        // definir a string de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress; Initial " +
                "Catalog=InLock_CodeFirst_Manha;User Id=sa; Pwd=132;");
            base.OnConfiguring(optionsBuilder);
        }


    }
}
