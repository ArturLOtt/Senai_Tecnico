using System;
using System.Collections.Generic;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class StatusConsulta
    {
        public StatusConsulta()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public ICollection<Consulta> Consulta { get; set; }
    }
}
