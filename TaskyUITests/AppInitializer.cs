﻿using Xamarin.UITest;
using System;

namespace TaskyUITests
{
    public static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .PreferIdeSettings()
                    .InstalledApp("com.xamarin.samples.taskydroid3")
                    .StartApp();
            }

            else if (platform == Platform.iOS)
            {
                return ConfigureApp
                    .iOS
                    .PreferIdeSettings()
                    .StartApp();
            }
            throw new Exception("AppInitializer: Unsupported platform " + platform);
        }
    }
}

