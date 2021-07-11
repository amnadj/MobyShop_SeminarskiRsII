using MobyShop.MobileA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.MobileA.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
