using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        public editModel(IItemRepository itemRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.itemRepository = itemRepository;
            this.webHostEnvironment = webHostEnvironment;
        }

        // Used to get the full path for storing the uploaded photos.  
        private readonly IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public Item Item { get; set; }

        [BindProperty]
        public List<Topics> Topics { get; set; }
        public List<Consumers> Consumers { get; set; }
        [BindProperty]
        public IFormFile ScreenShotPhoto { get; set; }


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

                if (ScreenShotPhoto != null)
                {
                    if (Item.ScreenShotPath != null)
                    {
                        string filePath = Path.Combine(webHostEnvironment.WebRootPath, "catalogScreenShots", Item.ScreenShotPath);
                        System.IO.File.Delete(filePath);
                    }
                    Item.ScreenShotPath = ProcessUploadedFile(ScreenShotPhoto);
                }
                return RedirectToPage("index");
            }
            
            // In the event there are validation issues we can re-render the page
            // so the user can correct any errors.
            return Page();
        }

        private string ProcessUploadedFile(IFormFile file)
        {
            string uniqueFileName = null;

            if (file != null)
            {
                string uploadsFolder =
                    Path.Combine(webHostEnvironment.WebRootPath, "catalogScreenShots");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}