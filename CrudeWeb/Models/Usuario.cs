using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace CrudeWeb.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string NomeLivro { get; set; }

        [Display(Name = "Autor")]
        [Column("Autor")]
        public string Autor { get; set; }

        [Display(Name = "Genero")]
        [Column("Genero")]
        public string Genero { get; set; }

        [Display(Name = "Data de Publicação")]
        [Column("DataPublicacao")]
        public DateOnly DataPublicacao { get; set; }
    }
}
