using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using UIT_CodeGym.MVVM.ViewModels;
using UIT_CodeGym.MVVM.Views;
using UIT_CodeGym.ViewModels;
using UIT_CodeGym.Controls;

namespace UIT_CodeGym;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Raleway-Regular.ttf", "RalewayRegular");
				fonts.AddFont("Raleway-ExtraBold.ttf", "RalewayExtraBold");
                fonts.AddFont("Raleway-SemiBold.ttf", "RalewaySemiBold");
				fonts.AddFont("Raleway-Bold.ttf", "RalewayBold");
                fonts.AddFont("Raleway-MediumItalic.ttf", "RalewayMediumItalic");
            });
    
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginPageVM>();
        builder.Services.AddSingleton<IntroductionPage>();
        builder.Services.AddSingleton<IntroductionVM>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageVM>();
        builder.Services.AddSingleton<PracticeBeginnerPage>();
        builder.Services.AddSingleton<PracticeBeginnerPageVM>();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("Borderless", (handler, view) =>
        {
            if (view is BorderlessEntry)
            {
#if MACCATALYST
handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
handler.PlatformView.Layer.BorderWidth = 0;
handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
#endif

            }
        });

        return builder.Build();
	}
}
