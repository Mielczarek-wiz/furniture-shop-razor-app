using Microsoft.AspNetCore.Components;
using MielczarekFurniture.Models.Dtos;
using MielczarekFurniture.UI.Services.Contracts;

namespace MielczarekFurniture.UI.Pages
{
    public class ProducersBase : ComponentBase
    {
        [Inject]
        public IProducerService ProducerService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string ErrorMessage { get; set; }
        public Boolean Ascending { get; set; } = true;
        public IEnumerable<ProducerDto> Producers { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Producers = await ProducerService.GetProducers();
            Producers = Producers.OrderBy(p => p.Name).ToList();
        }
        protected async Task AddProducer_Click()
        {
            NavigationManager.NavigateTo("/form-producers-add/-1");
        }
        protected async Task DeleteProducer_Click(int id)
        {
            try
            {
                await ProducerService.DeleteProducer(id);
                Producers = await ProducerService.GetProducers();
            }
            catch (Exception)
            {
                ErrorMessage = "Something went wrong during deleting a product.";
            }
        }
        protected async Task ModifyProducer_Click(int id)
        {
            NavigationManager.NavigateTo($"/form-producers-add/{id}");
        }

        protected async Task onSearchChangedAsync(ChangeEventArgs a)
        {
            string searchText = a.Value?.ToString() ?? "";
            Producers = await ProducerService.GetProducers();
            Producers = Producers.Where(p =>
            {
                return p.Name.ToLower().Contains(searchText.ToLower());
            });
        }
        protected async Task onOrderChanged()
        {
            Ascending = !Ascending;
            if (Ascending)
            {
                Producers = Producers.OrderBy(p => p.Name).ToList();
            }
            else
            {
                Producers = Producers.OrderByDescending(p => p.Name).ToList();
            }
            
        }
    }
}
