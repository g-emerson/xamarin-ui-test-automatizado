using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlataformTest
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{

                return ConfigureApp
                    .Android
                    //.InstalledApp("com.companyname.EAXamarinApp")
                    .ApkFile(@"C:\Users\Taurus\AppData\Local\Xamarin\Mono for Android\Archives\2018-07-04\EAXamarinApp.Android 7-04-18 11.33 AM.apkarchive\com.companyname.EAXamarinApp.apk")
                    .StartApp();
			}

			return ConfigureApp.iOS.StartApp();
		}
	}
}