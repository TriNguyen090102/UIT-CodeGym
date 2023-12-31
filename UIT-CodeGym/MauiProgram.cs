﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using UIT_CodeGym.MVVM.ViewModels;
using UIT_CodeGym.MVVM.Views;
using UIT_CodeGym.ViewModels;
using UIT_CodeGym.Controls;
using Syncfusion.Maui.Core.Hosting;

namespace UIT_CodeGym;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder.ConfigureSyncfusionCore();
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
        builder.Services.AddSingleton<QuizPage>();
        builder.Services.AddSingleton<QuizPageVM>();
        builder.Services.AddSingleton<SummaryPage>();
        builder.Services.AddSingleton<SummaryPageVM>();
        builder.Services.AddSingleton<AddQuestionsPage>();
        builder.Services.AddSingleton<AddQuestionsPageVM>();


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
