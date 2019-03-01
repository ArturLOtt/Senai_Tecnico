using System;
using System.ComponentModel.DataAnnotations;

namespace Senai.InLock.WebApi.Domains
{
    public class JogosDomain
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Jogo")]
        public string NomeJogo { get; set; }

        [Required(ErrorMessage = "Informe a Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Informe o Valor")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Informe o Estudio")]
        public int EstudioId { get; set; }
        public EstudiosDomain Estudio { get; set; }

    }
}
