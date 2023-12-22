using UIT_CodeGym.MVVM.Views;
using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym;

public partial class App : Application
{
    public static Realms.Sync.App RealmApp;

    public App()
    {
        InitializeComponent();
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk5MDk1MEAzMjM0MmUzMDJlMzBJdCtIMzNoeStzNjUwTnh3bk1lenFPM3k3emd3bnE1bG1HMitQMUd2dVhzPQ==");
        RealmApp = Realms.Sync.App.Create(AppConfig.RealmAppId);

        MainPage = new AppShell();
    }
}
