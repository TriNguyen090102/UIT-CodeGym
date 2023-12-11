using UIT_CodeGym.MVVM.Views;
namespace UIT_CodeGym;

public partial class App : Application
{
    public static Realms.Sync.App RealmApp;

    public App()
	{
		InitializeComponent();
        RealmApp = Realms.Sync.App.Create(AppConfig.RealmAppId);

        //MainPage = new AppShell();
        MainPage = new ForumPage();
    }
}

