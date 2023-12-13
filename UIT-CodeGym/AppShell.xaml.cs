
using UIT_CodeGym.MVVM.Views;

namespace UIT_CodeGym;

public partial class AppShell : Shell
{
    public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(IntroductionPage), typeof(IntroductionPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(PracticeAdvancedPage), typeof(PracticeAdvancedPage));
        Routing.RegisterRoute(nameof(PracticeBeginnerPage), typeof(PracticeBeginnerPage));
        Routing.RegisterRoute(nameof(PracticeImmediatePage), typeof(PracticeImmediatePage));
        Routing.RegisterRoute(nameof(ForumPage), typeof(ForumPage));
        Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));

    }
}