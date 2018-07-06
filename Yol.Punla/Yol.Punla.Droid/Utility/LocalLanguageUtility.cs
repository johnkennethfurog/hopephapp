﻿using Xamarin.Forms;
using Java.Util;
using Yol.Punla.Utility;

[assembly: Dependency(typeof(Yol.Punla.Droid.Utility.LocalLanguageUtility))]
namespace Yol.Punla.Droid.Utility
{
    public class LocalLanguageUtility : ILocalLanguageUtility
    {
        public string GetLanguageLocale()
        {
            return Locale.Default.GetDisplayLanguage(Locale.Default);
        }
    }
}