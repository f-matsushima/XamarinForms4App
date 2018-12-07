using System;
using System.Collections.Generic;
using System.Linq;
using XamarinForms4App.Models;

namespace XamarinForms4App.ViewModels
{
    public class CollectionPageViewModel
    {
        public List<Item> Items { get; }

        public CollectionPageViewModel()
        {
            Items = Enumerable.Range(0, 100)
                              .Select(i => new Item { Title = $"title{i}", Detail = $"detail{i}" })
                              .ToList();
        }
    }
}
