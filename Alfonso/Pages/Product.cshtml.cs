using System;
using System.Threading.Tasks;
using Alfonso.Interfaces;
using Alfonso.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alfonso.Pages
{
    public class ProductModel : PageModel
    {
        private readonly ICatalogRazorService _catalogService;

        public ProductModel(ICatalogRazorService catalogService)
        {
            _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));
        }

        public CatalogItemViewModel CatalogItem { get; set; }        

        public async Task OnGet(string slug)
        {
            CatalogItem = await _catalogService.GetCatalogItem(slug);            
        }
    }
}