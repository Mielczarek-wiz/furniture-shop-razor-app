using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MielczarekFurniture.Models.Dtos
{
    public class ProductFormDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Description is too short")]
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be bigger than 0")]
        public decimal Price { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string ProducerName { get; set; }
    }
}
