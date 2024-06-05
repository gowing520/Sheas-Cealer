﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;
using Sheas_Cealer.Consts;

namespace Sheas_Cealer.Convs;

internal class MainSettingsBoxToolTipConv : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        MainConst.SettingsMode? mode = value as MainConst.SettingsMode?;

        return mode switch
        {
            MainConst.SettingsMode.BrowserPathMode => MainConst.SettingsBoxBrowserPathPlaceHolder,
            MainConst.SettingsMode.UpstreamUrlMode => MainConst.SettingsBoxUpstreamUrlPlaceHolder,
            MainConst.SettingsMode.ExtraArgsMode => MainConst.SettingsBoxExtraArgsPlaceHolder,
            _ => throw new UnreachableException()
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}