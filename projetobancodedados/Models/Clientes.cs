using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace projetobancodedados.Models
{
    [Table("tb_clientes")]
    public class Clientes
    {
        [Display(Name = "Código")]
        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome Cliente")]
        [Column("nome")]
        public string Nomec { get; set; }

        [Display(Name = "Sexo do cliente")]
        [Column("sexo")]
        public string Cpfc { get; set; }

        [Display(Name = "Data de nascimento")]
        [Column("nascimento")]
        public DateTime DataNascimento { get; set; }

    }
}
