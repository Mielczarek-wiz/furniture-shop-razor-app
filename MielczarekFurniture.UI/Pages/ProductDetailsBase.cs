using Microsoft.AspNetCore.Components;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.UI.Services.Contracts;

namespace MielczarekFurniture.UI.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ProductDto Product { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Product = await ProductService.GetItem(Id);
            }
            catch (Exception e)
            {

                ErrorMessage = e.Message;
            }
        }
        protected async Task DeleteItem_Click(int id)
        {
            try
            {
                await ProductService.DeleteItem(id);
                NavigationManager.NavigateTo("/");
            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong during deleting a product.";
            }
        }
        protected void ModifyItem_Click(int id)
        {
            try
            {
                NavigationManager.NavigateTo($"/form-add/{id}");
            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong during modifying a product.";
            }
        }

    }
}
