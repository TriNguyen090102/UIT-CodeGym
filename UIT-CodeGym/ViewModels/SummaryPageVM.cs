using CommunityToolkit.Mvvm.Input;
using UIT_CodeGym.MVVM.ViewModels;

namespace UIT_CodeGym.ViewModels
{
    public partial class SummaryPageVM : BaseViewModel
    {
        public SummaryPageVM() { }
        [RelayCommand]
        public static async void StartForum()
        {
            await Shell.Current.GoToAsync("///Forum");

        }
        [RelayCommand]
        public static async void StartTest()
        {
            await Shell.Current.GoToAsync("///Test");

        }

        [RelayCommand]
        public static async void StartAbout()
        {
            await Shell.Current.GoToAsync("///About");
        }
        [RelayCommand]
        public static async void StartMain()
        {
            await Shell.Current.GoToAsync("///Main");
        }

        [RelayCommand]
        public static async void StartQuiz()
        {
            await Shell.Current.GoToAsync("///Quiz");
        }

    }
}
