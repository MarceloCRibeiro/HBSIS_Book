using System;
using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Titulo")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Mínimo de 3 e Máximo de 60 caracteres")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Campo requerido")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        [Display(Name = "Publicação")]
        public DateTime PublishDate { get; set; }
        
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Autor")]
        public string Author { get; set; }
        
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Gênero")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genre { get; set; }
        
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Preço")]
        [Range(1, 1000, ErrorMessage = "Valor máximo 1000")]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Valor inválido")]
        [DataType(DataType.Currency, ErrorMessage = "Valor inválido")]        
        public decimal Price { get; set; }

    }
}