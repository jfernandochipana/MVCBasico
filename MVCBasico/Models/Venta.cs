using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace MVCBasico.Models
{
    public class Venta
    {

       
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public string ventaId { get; set; }
            public Cliente cliente { get; set; }
            public string producto { get; set; }

            public string numeroTarjeta { get; set; }
            public string vencTarjeta { get; set; }
            public string nombreTarjeta { get; set; }
            public string cvv { get; set; }


    }
    }

