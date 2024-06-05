﻿using System;
using System.Globalization;
using System.Windows.Data;
using Sheas_Cealer.Consts;

namespace Sheas_Cealer.Convs;

internal class MainSettingsModeButtonContentConv : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        MainConst.SettingsMode? mode = value as MainConst.SettingsMode?;

        return mode switch
        {
            MainConst.SettingsMode.BrowserPathMode => MainConst.UpstreamUrlModeName,
            MainConst.SettingsMode.UpstreamUrlMode => MainConst.ExtraArgsModeName,
            MainConst.SettingsMode.ExtraArgsMode => MainConst.BrowserPathModeName,
            _ => throw new NotImplementedException()
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}