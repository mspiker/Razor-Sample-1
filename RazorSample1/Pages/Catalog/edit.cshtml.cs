using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSample1.Models;
using RazorSample1.Services;

namespace RazorSample1.Pages.Catalog
{
    public class editModel : PageModel
    {
        private readonly IItemRepository itemRepository;
        public editModel(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        
        [BindProperty]
        public Item Item { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                Item = itemRepository.GetItem(id.Value);
            } else
            {
                Item = new Item();
            }
            if (Item == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}