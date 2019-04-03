using System;
using System.Collections.Generic;

namespace InLock.DatabaseFirst.Solution.Domains
{
    public partial class Jogos
    {
        public int Jogoid { get; set; }
        public string Nomejogo { get; set; }
        public string Descricao { get; set; }
        public DateTime Datalancamento { get; set; }
        public decimal Valor { get; set; }
        public int Estudioid { get; set; }

        public Estudios Estudio { get; set; }
    }
}
