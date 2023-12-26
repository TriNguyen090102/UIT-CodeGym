
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Maui.Controls;
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
        public QuizPageVM()
        {
            OperatorQuestions = new ObservableCollection<QuestionModel>();
            PointerQuestions = new ObservableCollection<QuestionModel>();
            SwitchQuestions = new ObservableCollection<QuestionModel>();
                   }
    
        QuestionsService service = new QuestionsService();
        public List<QuestionModel> PopulateOperatorQuestions()
        {
            List<QuestionModel> questions = new List<QuestionModel>();
            var documents = service.FetchOperatorsQuestions();
            foreach (QuestionModel qs in documents)
            {
                OperatorQuestions.Add(qs);
                questions.Add(qs);
            }

            return questions;
        }


        public void PopulatePointerQuestions()
        {
            var documents = service.FetchPointerQuestions();
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
                OperatorQuestions.Add(qs);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        [RelayCommand]
        public static async void StartSummary()
        {
            await Shell.Current.GoToAsync("///Summary");
        }

    }
    
}