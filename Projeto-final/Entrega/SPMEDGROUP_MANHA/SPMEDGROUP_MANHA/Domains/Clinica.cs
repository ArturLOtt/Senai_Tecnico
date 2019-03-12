using System;
using System.Collections.Generic;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class Clinica
    {
        public int Id { get; set; }
        public int Cnpj { get; set; }
        public string Endereco { get; set; }
        public DateTime DataInicio { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string HorarioFuncionamento { get; set; }
        public int? IdMedico { get; set; }

        public TipoMedico IdMedicoNavigation { get; set; }
    }
}
