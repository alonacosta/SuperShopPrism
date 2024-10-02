using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShopPrism.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShopPrism.ViewModels
{
	public class ShowCarPageViewModel : ViewModelBase
	{
        public ShowCarPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ShowShoppingCar;
        }
	}
}
