using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace projetobancodedados.Models
{
    [Table("tb_vendas")]
    public class Vendas
    {
        [Display(Name = "Código")]
        [Column("id")]
        [Key]
        public int Id_v { get; set; }

        [Display(Name = "Data da venda")]
        [Column("data")]
        public DateTime data_v { get; set; }

        [Display(Name = "Valor da venda")]
        [Column("valor")]
        public double valor_v { get; set; }

        [Display(Name = "Id do cliente")]
        [Column("tb_clientes_id")]
        public int tb_clientes_id { get; set; }
    }
}
