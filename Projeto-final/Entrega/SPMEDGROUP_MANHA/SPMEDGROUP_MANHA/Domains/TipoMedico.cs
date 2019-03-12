using System;
using System.Collections.Generic;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class TipoMedico
    {
        public TipoMedico()
        {
            Clinica = new HashSet<Clinica>();
            Consulta = new HashSet<Consulta>();
        }

        public int Id { get; set; }
        public string Crm { get; set; }
        public int? IdAreaClinica { get; set; }
        public int? IdUsuario { get; set; }

        public AreaClinica IdAreaClinicaNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
        public ICollection<Clinica> Clinica { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
