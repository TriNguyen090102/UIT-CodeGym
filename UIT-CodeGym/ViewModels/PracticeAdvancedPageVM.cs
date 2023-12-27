using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIT_CodeGym.MVVM.ViewModels;
using UIT_CodeGym.MVVM.Views;
using UIT_CodeGym.Services;

namespace UIT_CodeGym.ViewModels
{
    public partial class PracticeAdvancedPageVM :BaseViewModel
    {
        public PracticeAdvancedPageVM() { }
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
        public static async void LogOut()
        {
            await Shell.Current.GoToAsync("///Introduction");
            AppProperties.UserName = "";
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
        public static async void StartPointerQuiz()
        {
            var quizViewModel = new QuizPageVM();
            quizViewModel.Title = "pointer";
            var quizPage = new QuizPage(quizViewModel);
            await Shell.Current.Navigation.PushAsync(quizPage);
        }

    }
}
