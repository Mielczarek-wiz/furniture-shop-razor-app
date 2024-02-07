using Microsoft.AspNetCore.Components;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.UI.Services.Contracts;

namespace MielczarekFurniture.UI.Pages
{
    public class ProductFormsBase : ComponentBase
    {

        public ProductFormDto Product { get; set; } = new();
        public IEnumerable<ProducerDto> Producers  { get; set; } = Enumerable.Empty<ProducerDto>();

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public IProducerService ProducerService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Producers = await ProducerService.GetProducers();
                if (Id != -1)
                {
                    var productDto = await ProductService.GetItem(Id);
                    Product = new ProductFormDto
                    {
                        Name = productDto.Name,
                        Description = productDto.Description,
                        ImageURL = productDto.ImageURL,
                        Price = productDto.Price,
                        ProducerName = productDto.Producer.Name
                    };
                }
                else
                {
                    Product = new();
                    Product.ProducerName = Producers.First().Name;
                }
            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong.";
            } 
 
        }
        protected async Task AddItem_Click()
        {
            try
            {
                var newProductDto = await ProductService.AddItem(Product);
                NavigationManager.NavigateTo("/");
                
            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong during adding a product.";
            }
        }
        protected async Task ModifyItem_Click()
        {
            try
            {
                var modifyiedProductDto = await ProductService.ModifyItem(Id, Product);
                NavigationManager.NavigateTo($"/ProductDetails/{Id}");

            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong during modifying a product.";
            }
        }
    }
}
