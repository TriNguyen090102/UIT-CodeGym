using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using UIT_CodeGym.MVVM.ViewModels;
using UIT_CodeGym.MVVM.Views;
using UIT_CodeGym.ViewModels;

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
        builder.Services.AddSingleton<PracticeImmediatePage>();
        builder.Services.AddSingleton<PracticeImmediatePageVM>();
        builder.Services.AddSingleton<PracticeAdvancedPage>();
        builder.Services.AddSingleton<PracticeAdvancedPageVM>();
        builder.Services.AddSingleton<AboutPage>();
        builder.Services.AddSingleton<AboutPageVM>();
        builder.Services.AddSingleton<TestPage>();
        builder.Services.AddSingleton<TestPageVM>();
        builder.Services.AddSingleton<ForumPage>();
        builder.Services.AddSingleton<ForumPageVM>();



        return builder.Build();
	}
}
