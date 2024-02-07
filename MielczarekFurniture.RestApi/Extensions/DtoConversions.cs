using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.RestApi.Entities;

namespace MielczarekFurniture.RestApi.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<Producer> producers)
        {
            return (from product in products
                    join producer in producers on product.Producer.Id equals producer.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Producer = new ProducerDto
                        {
                            Id = producer.Id,
                            Name = producer.Name,
                            Star = producer.Star
                        },
                    }).ToList();
        }

        public static ProductDto ConvertToDto(this Product product, Producer producer)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageURL = product.ImageURL,
                Price = product.Price,
                Producer = new ProducerDto
                {
                    Id = producer.Id,
                    Name = producer.Name,
                    Star = producer.Star
                },
            };
        }

        public static IEnumerable<ProducerDto> ConvertToDto(this IEnumerable<Producer> producers)
        {
            return (from producer in producers
                    select new ProducerDto
                    {
                        Id = producer.Id,
                        Name = producer.Name,
                        Star = producer.Star

                    }).ToList();
        }

        public static ProducerDto ConvertToDto(this Producer producer)
        {
            return new ProducerDto
            {
                Id = producer.Id,
                Name = producer.Name,
                Star = producer.Star
            };
        }
    }
}
