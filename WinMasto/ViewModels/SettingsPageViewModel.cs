﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace WinMasto.ViewModels
{
    public class SettingsPageViewModel : WinMastoViewModel
    {
        public SettingsPartViewModel SettingsPartViewModel { get; } = new SettingsPartViewModel();
        public AboutPartViewModel AboutPartViewModel { get; } = new AboutPartViewModel();
    }

    public class SettingsPartViewModel : WinMastoViewModel
    {
        readonly Services.SettingsService _settings;

        public SettingsPartViewModel()
        {
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                _settings = Services.SettingsService.Instance;
        }

        public bool UseDarkThemeButton
        {
            get { return _settings.AppTheme.Equals(ApplicationTheme.Dark); }
            set { _settings.AppTheme = value ? ApplicationTheme.Dark : ApplicationTheme.Light; base.RaisePropertyChanged(); }
        }
    }

    public class AboutPartViewModel : WinMastoViewModel
    {
       
    }
}
