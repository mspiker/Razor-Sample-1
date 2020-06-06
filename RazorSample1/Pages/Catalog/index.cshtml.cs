using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSample1.Models;
using RazorSample1.Services;
using RazorSample1.Models.Enums;

namespace RazorSample1.Pages.Catalog
{
    public class indexModel : PageModel
    {
        private readonly IItemRepository itemRepository;
        
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<ReportingTools> Tools { get; set; }
        [BindProperty(SupportsGet = true)] 
        public List<Products> Product { get; set; }

        public indexModel(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public IEnumerable<Item> Items { get; set; }

        public void OnGet()
        {
            Items = itemRepository.GetAllItems(10,2);    
        }
    }
}