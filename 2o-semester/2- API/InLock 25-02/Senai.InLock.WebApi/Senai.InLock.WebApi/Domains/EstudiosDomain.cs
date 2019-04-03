using System.ComponentModel.DataAnnotations;


namespace Senai.InLock.WebApi.Domains
{
    public class EstudiosDomain
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Estudio")]
        public string NomeEstudio { get; set; }

        
    }
}
