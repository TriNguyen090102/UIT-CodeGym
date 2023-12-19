using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.MVVM.ViewModels;

namespace UIT_CodeGym.ViewModels
{
    public partial class QuizPageVM : BaseViewModel
    {
        public ObservableCollection<QuestionModel> OperatorQuestions { get; set; }
        public ObservableCollection<QuestionModel> PointerQuestions { get; set; }
        public ObservableCollection<QuestionModel> SwitchQuestions { get; set; }

        public QuizPageVM() {
            OperatorQuestions = new ObservableCollection<QuestionModel>();
            PointerQuestions = new ObservableCollection<QuestionModel>();
            SwitchQuestions = new ObservableCollection<QuestionModel>();
        }

        QuestionsService service = new QuestionsService();
        public void PopulateOperatorQuestions()
        {
            var documents = service.FetchOperatorsQuestions();
            foreach (QuestionModel qs in documents)
            {
                OperatorQuestions.Add(qs);
            }
        }

        public void PopulateSwitchQuestions()
        {
            var documents = service.FetchSwitchQuestions();
            foreach (QuestionModel qs in documents)
            {
                SwitchQuestions.Add(qs);
            }
        }


        public void PopulatePointerQuestions()
        {
            var documents = service.FetchPointerQuestions();
            foreach (QuestionModel qs in documents)
            {
                PointerQuestions.Add(qs);
            }
        }

        public void Test()
        {
            string data = "";
            foreach(QuestionModel qs in OperatorQuestions)
            {
                data += qs.question;
            }
            Shell.Current.DisplayAlert(data, "", "exit");
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
            await Shell.Current.GoToAsync("///Main");
        }



    }
}
