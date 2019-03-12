using System;
using System.Collections.Generic;

namespace SPMEDGROUP_MANHA.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            ProntuarioPaciente = new HashSet<ProntuarioPaciente>();
            TipoMedico = new HashSet<TipoMedico>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string TelefoneContato { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? IdTipoUsuario { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public TipoUsuarios IdTipoUsuarioNavigation { get; set; }
        public ICollection<ProntuarioPaciente> ProntuarioPaciente { get; set; }
        public ICollection<TipoMedico> TipoMedico { get; set; }
    }
}
