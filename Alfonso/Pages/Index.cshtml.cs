using System;
using System.Threading.Tasks;
using Alfonso.Interfaces;
using Alfonso.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alfonso.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICatalogService _catalogService;

        public IndexModel(ICatalogService catalogService)
        {
            _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));            
        }
        
        public CatalogIndexViewModel CatalogModel { get; set; } = new CatalogIndexViewModel();        

        public async Task OnGet(CatalogIndexViewModel catalogModel, int? pageId)
        {
            CatalogModel = await _catalogService.GetCatalogItems(pageId ?? 0, Constants.ITEMS_PER_PAGE, catalogModel.BrandFilterApplied, catalogModel.TypesFilterApplied);            
        }

        public async Task<IActionResult> OnPostAddToCompare(CatalogItemViewModel productDetails)
        {
            if (productDetails?.Id == null)
            {
                return RedirectToPage("/Index");
            }
            //await SetBasketModelAsync();

            //await _basketService.AddItemToBasket(BasketModel.Id, productDetails.Id, productDetails.Price, 1);

            //await SetBasketModelAsync();

            return RedirectToPage();
        }
    }
}