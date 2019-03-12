using System;
using System.Collections.Generic;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class ProntuarioPaciente
    {
        public ProntuarioPaciente()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public string Notas { get; set; }
        public string Doencas { get; set; }
        public string Remedios { get; set; }

        public Usuarios IdUsuarioNavigation { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
