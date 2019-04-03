using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InLock.CodeFirst.WebApi.Manha.Domains
{
    [Table("Estudios")]
    public class EstudioDomain
    {

        // primary key
        [Key]
        // gerar id com auto incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstudioId { get; set; }

        // varchar(250)
        // "NomeEstudio" para mudar o nome da tabela rapidamt
        [Column("NomeEstudio", TypeName = "varchar(250)")]
        // not null
        [Required]
        public string NomeEstudio { get; set; }

        public List<JogoDomain> Jogos { get; set; }


    }
}
