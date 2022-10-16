using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace projetobancodedados.Models
{
    [Table("tb_usuarios")]
    public class Usuarios
    {
        [Display(Name = "Código")]
        [Column("id")]
        [Key]
        public int Id_u { get; set; }

        [Display(Name = "Nome Cliente")]
        [Column("nome")]
        public string Nome_u { get; set; }

        [Display(Name = "Usuario do cliente")]
        [Column("usuario")]
        public string usuario { get; set; }

        [Display(Name = "Senha")]
        [Column("senha")]
        public string senha { get; set; }
    }
}
