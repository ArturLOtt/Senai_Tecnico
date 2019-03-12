using System;
using System.Collections.Generic;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class AreaClinica
    {
        public AreaClinica()
        {
            TipoMedico = new HashSet<TipoMedico>();
        }

        public int Id { get; set; }
        public string Especialidade { get; set; }

        public ICollection<TipoMedico> TipoMedico { get; set; }
    }
}
