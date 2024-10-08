﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SuperShopPrism.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperShopPrism.ViewModels
{
	public class ModifyUserPageViewModel : ViewModelBase
	{
        public ModifyUserPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.ModifyUser;
        }
	}
}
