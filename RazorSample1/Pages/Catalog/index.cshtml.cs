using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSample1.Models;
using RazorSample1.Services;

namespace RazorSample1.Pages.Catalog
{
    public class indexModel : PageModel
    {
        private readonly IItemRepository itemRepository;

        public indexModel(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        public IEnumerable<Item> Items { get; set; }

        public void OnGet()
        {
            Items = itemRepository.GetAllItems();    
        }
    }
}