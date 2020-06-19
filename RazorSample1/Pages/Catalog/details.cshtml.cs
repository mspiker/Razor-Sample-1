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
    public class detailsModel : PageModel
    {
        private readonly IItemRepository itemRepository;

        public detailsModel(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public Item Item { get; private set; }

        public IActionResult OnGet(int id)
        {
            Item = itemRepository.GetItem(id);
            if (Item==null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}