﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.MVVM.ViewModels;
using UIT_CodeGym.MVVM.Views;

namespace UIT_CodeGym.ViewModels
{
    public partial class SummaryPageVM : BaseViewModel
    {
        public ObservableCollection<UserRecordModel> UsersRecord { get; set; }
        [ObservableProperty]
        int correctAnswerCount;
        [ObservableProperty]
        int inCorrectAnswerCount;
        [ObservableProperty]
        string title;
         QuestionsService service = new QuestionsService();
        public SummaryPageVM()
        {
            CorrectAnswerCount = 0;
            InCorrectAnswerCount = 0;
            Title = "";
            UsersRecord = new ObservableCollection<UserRecordModel>();
        }
        public List<UserRecordModel> PopulateUsersRecord()

        {
            List<UserRecordModel> record = new List<UserRecordModel>();
            var documents = service.FetchUsersRecord(Title);
            foreach (UserRecordModel rc in documents)
            {
                UsersRecord.Add(rc);
                record.Add(rc);
            }

            return record;
        }

        [RelayCommand]
        public void CheckUsersRecord()
        {
            string tmp = "";
            foreach(UserRecordModel rc in UsersRecord)
            {
                tmp += rc.userName + rc.Score;
            }
            Shell.Current.DisplayAlert("", tmp, "ok");
                
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
        [RelayCommand]
        public static async void StartMain()
        {
            await Shell.Current.Navigation.PopAsync();
            await Shell.Current.GoToAsync("///Main");
        }

        [RelayCommand]
        public static async void StartQuiz()
        {
            await Shell.Current.GoToAsync("///Quiz");
        }

        [RelayCommand]
        public async void PracticeAgain()
        {
                var quizViewModel = new QuizPageVM();
                quizViewModel.Title = Title;
                var quizPage = new QuizPage(quizViewModel);
                await Shell.Current.Navigation.PushAsync(quizPage);
        }
    }
}
