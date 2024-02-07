using Microsoft.AspNetCore.Components;
using MielczarekFurniture.Core.Enums;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.UI.Services.Contracts;

namespace MielczarekFurniture.UI.Pages
{
    public class ProducerFormsBase : ComponentBase
    {
        public ProducerFormDto Producer { get; set; }

        [Parameter]
        public int Id { get; set; }

        public IEnumerable<Stars> Star { get; set; } = (IEnumerable<Stars>)Enum.GetValues(typeof(Stars));

        [Inject]
        public IProducerService ProducerService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Producer = new();
                if (Id != -1)
                {
                    var producerDto = await ProducerService.GetProducer(Id);
                    Producer = new ProducerFormDto
                    {
                        Name = producerDto.Name,
                        Star = producerDto.Star
                    };
                }
            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong.";
            }

        }
        protected async Task AddProducer_Click()
        {
            try
            {
                var newProductDto = await ProducerService.AddProducer(Producer);
                NavigationManager.NavigateTo("/producers");

            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong during adding a product.";
            }
        }
        protected async Task ModifyProducer_Click()
        {
            try
            {
                var modifyiedProductDto = await ProducerService.UpdateProducer(Id, Producer);
                NavigationManager.NavigateTo($"/producers");

            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong during modifying a product.";
            }
        }
    }
}
