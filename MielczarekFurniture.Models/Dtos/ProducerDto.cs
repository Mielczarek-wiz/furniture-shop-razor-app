using MielczarekFurniture.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MielczarekFurniture.Models.Dtos
{
    public class ProducerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Stars Star { get; set; }
    }
}
