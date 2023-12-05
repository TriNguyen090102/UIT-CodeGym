using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIT_CodeGym.MVVM.ViewModels;

namespace UIT_CodeGym.ViewModels
{
    public partial class IntroductionVM : BaseViewModel
    {
        public IntroductionVM() { }

        [RelayCommand]
        public static async void StartLogin()
        {
            await Shell.Current.GoToAsync("///Login");
        }
    }
}
