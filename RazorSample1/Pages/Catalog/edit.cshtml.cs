﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSample1.Models;
using RazorSample1.Models.Enums;
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

        [BindProperty]
        public List<Topics> Topics { get; set; }
        public List<Consumers> Consumers { get; set; }


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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Item.Topics = Topics;
                Item.Consumers = Consumers;
            }
            return Page();
        }
    }
}