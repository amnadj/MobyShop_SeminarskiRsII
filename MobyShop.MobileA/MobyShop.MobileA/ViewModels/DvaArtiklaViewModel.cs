using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.MobileA.ViewModels
{
    class DvaArtiklaViewModel : BaseViewModel
    {
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");
        private readonly APIService _artikliService = new APIService("Artikli");
        public DvaArtiklaViewModel()
        {

        }
        public Artikli Artikal1 { get; set; }
        public Artikli Artikal2 { get; set; }
        public Karakteristike Karakteristika1 { get; set; } = new Karakteristike();
        public Karakteristike Karakteristika2 { get; set; } = new Karakteristike();

        bool _NovoPrvi_IsVisible;
        public bool NovoPrvi_IsVisible
        {
            get { return _NovoPrvi_IsVisible; }
            set
            {
                SetProperty(ref _NovoPrvi_IsVisible, value);
            }
        }

        bool _PolovnoPrvi_IsVisible;
        public bool PolovnoPrvi_IsVisible
        {
            get { return _PolovnoPrvi_IsVisible; }
            set
            {
                SetProperty(ref _PolovnoPrvi_IsVisible, value);

            }
        }
        bool _NovoDrugi_IsVisible;
        public bool NovoDrugi_IsVisible
        {
            get { return _NovoDrugi_IsVisible; }
            set
            {
                SetProperty(ref _NovoDrugi_IsVisible, value);
            }
        }

        bool _PolovnoDrugi_IsVisible;
        public bool PolovnoDrugi_IsVisible
        {
            get { return _PolovnoDrugi_IsVisible; }
            set
            {
                SetProperty(ref _PolovnoDrugi_IsVisible, value);

            }
        }
    }
}
