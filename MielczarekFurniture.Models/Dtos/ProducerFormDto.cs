using MielczarekFurniture.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MielczarekFurniture.Models.Dtos
{
    public class ProducerFormDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name is too short")]
        public string Name { get; set; }

        [Required]
        public Stars Star { get; set; }
    }
}
