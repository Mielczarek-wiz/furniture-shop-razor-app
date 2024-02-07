using Microsoft.AspNetCore.Components;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.UI.Services.Contracts;

namespace MielczarekFurniture.UI.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
        public Boolean Ascending { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
            Products = Products.OrderBy(p => p.Name).ToList();
        }
        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByProducer()
        {
            return from product in Products group product by product.Producer.Id into prodByProducer orderby prodByProducer.Key select prodByProducer;
        }
        protected string GetProducerName(IGrouping<int, ProductDto> groupedProductsDtos)
        {
            return groupedProductsDtos.FirstOrDefault(pg => pg.Producer.Id == groupedProductsDtos.Key).Producer.Name;
        }
        protected async Task AddProduct_Click()
        {
            NavigationManager.NavigateTo("/form-add/-1");
        } 
        protected async Task onSearchChangedAsync(ChangeEventArgs a)
        {
            string searchText = a.Value?.ToString() ?? "";
           Products = await ProductService.GetItems();
           Products = Products.Where(p =>
           {
                return p.Name.ToLower().Contains(searchText.ToLower());
           });
        }
        protected async Task onOrderChanged()
        {
            Ascending = !Ascending;
            if (Ascending)
            {
                Products = Products.OrderBy(p => p.Name).ToList();
            }
            else
            {
                Products = Products.OrderByDescending(p => p.Name).ToList();
            }

            
        }
    }
}
