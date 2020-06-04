using RazorSample1.Models;
using System;
using System.Collections.Generic;

namespace RazorSample1.Services
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAllItems();

    }
}
