using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; } //el "?" indica que la propiedad admite un valor NULL 

        [Display(Name="Release Date")]
        [DataType(DataType.Date)] //Con el atributo date el usuario no tiene que especificar informacion horaria en el campo fecha.
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; } //Admite valor null

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
