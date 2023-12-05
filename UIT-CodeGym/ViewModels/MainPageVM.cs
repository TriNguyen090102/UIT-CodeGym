using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIT_CodeGym.MVVM.ViewModels;

namespace UIT_CodeGym.ViewModels
{
    public partial class MainPageVM : BaseViewModel
    {
        [RelayCommand]
        public static async void StartBeginnerPractice()
        {
            await Shell.Current.GoToAsync("///BeginnerPractice");
        }
        [RelayCommand]
        public static async void StartImmediatePractice()
        {
        }
        [RelayCommand]
        public static async void StartAdvancePractice()
        {
        }
    }
}
