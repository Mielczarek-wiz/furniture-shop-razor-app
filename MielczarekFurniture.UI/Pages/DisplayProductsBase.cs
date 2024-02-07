using Microsoft.AspNetCore.Components;
using MielczarekFurniture.Models.Dtos;

namespace MielczarekFurniture.UI.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
