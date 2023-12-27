using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIT_CodeGym.MVVM.ViewModels;
using UIT_CodeGym.Services;

namespace UIT_CodeGym.ViewModels
{
    public partial class AboutPageVM :BaseViewModel
    {
        public AboutPageVM() { }


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
        public static async void StartMain()
        {
            await Shell.Current.GoToAsync("///Main");
        }
        [RelayCommand]
        public static async void LogOut()
        {
            await Shell.Current.GoToAsync("///Introduction");
            AppProperties.UserName = "";
        }

    }
}
