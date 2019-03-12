using System;
using System.Collections.Generic;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class Consulta
    {
        public int Id { get; set; }
        public int? IdStatusConsulta { get; set; }
        public DateTime DataAgendamento { get; set; }
        public int? IdMedico { get; set; }
        public int? IdPaciente { get; set; }
        public string Descricao { get; set; }

        public TipoMedico IdMedicoNavigation { get; set; }
        public ProntuarioPaciente IdPacienteNavigation { get; set; }
        public StatusConsulta IdStatusConsultaNavigation { get; set; }
    }
}
