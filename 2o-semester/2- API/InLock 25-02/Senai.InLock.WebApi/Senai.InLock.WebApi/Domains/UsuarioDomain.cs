using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    public class UsuarioDomain
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o tipo de usuário")]
        public string TipoUsuario { get; set; }
    }

}
