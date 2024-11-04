using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCBasico.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public String Domicilio { get; set; }

        //[Display(Name = "Fecha inscripción")]
        //public DateTime FechaInscripto { get; set; }

        //[EnumDataType(typeof(Deporte))]
        //[Display(Name = "Seleccione el deporte favorito:")]
        //public Deporte DeporteFavorito { get; set; }
    }
}
