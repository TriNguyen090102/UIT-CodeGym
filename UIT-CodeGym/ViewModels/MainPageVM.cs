using Amazon.Runtime.Internal.Util;
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
            await Shell.Current.GoToAsync("///ImmediatePractice");

        }
        [RelayCommand]
        public static async void StartAdvancePractice()
        {
            await Shell.Current.GoToAsync("///AdvancePractice");

        }
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


    }
}
