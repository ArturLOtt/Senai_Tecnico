using System;
using System.Collections.Generic;

namespace InLock.DatabaseFirst.Solution.Domains
{
    public partial class Estudios
    {
        public Estudios()
        {
            Jogos = new HashSet<Jogos>();
        }

        public int Estudioid { get; set; }
        public string Nomeestudio { get; set; }

        public ICollection<Jogos> Jogos { get; set; }
    }
}
