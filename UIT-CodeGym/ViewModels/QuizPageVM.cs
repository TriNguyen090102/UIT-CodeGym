using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
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

       


        [ObservableProperty]
        List<QuestionModel> operatorQuestions;
        [ObservableProperty]
        List<QuestionModel> pointerQuestions;
        [ObservableProperty]
        List<QuestionModel> switchQuestions;
        public QuizPageVM() {
            operatorQuestions = new List<QuestionModel>();
            pointerQuestions = new List<QuestionModel>();
            switchQuestions = new List<QuestionModel>();
        }

        QuestionsService service = new QuestionsService();
        public void PopulateOperatorQuestions()
        {
            var documents = service.FetchOperatorsQuestions();
            foreach(QuestionModel qs in documents)
            {
                operatorQuestions.Add(qs);
            }
        }

        public void PopulateSwitchQuestions()
        {
            var documents = service.FetchSwitchQuestions();
            foreach (QuestionModel qs in documents)
            {
                switchQuestions.Add(qs);
            }
        }


        public void PopulatePointerQuestions()
        {
            var documents = service.FetchPointerQuestions();
            foreach (QuestionModel qs in documents)
            {
                pointerQuestions.Add(qs);
            }
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
