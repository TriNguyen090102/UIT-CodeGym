
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


    }
}