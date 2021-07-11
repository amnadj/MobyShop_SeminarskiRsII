using MobyShop.MobileA.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.MobileA
{
    public class CartService
    {

        public static Dictionary<int, ArtikliDetailViewModel> Cart = new Dictionary<int, ArtikliDetailViewModel>();
    }
}
