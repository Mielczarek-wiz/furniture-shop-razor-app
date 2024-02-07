using Microsoft.EntityFrameworkCore;
using MielczarekFurniture.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace MielczarekFurniture.RestApi.Entities
{
    [Owned]
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Stars Star { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
