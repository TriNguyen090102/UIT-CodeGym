
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Maui.Controls;
using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.MVVM.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace UIT_CodeGym.ViewModels
{

    public partial class QuizPageVM : BaseViewModel 
    {
        public ObservableCollection<QuestionModel> OperatorQuestions { get; set; }
      

        [ObservableProperty]
        string title;

        QuestionsService service = new QuestionsService();

        public QuizPageVM()
        {
            OperatorQuestions = new ObservableCollection<QuestionModel>();
           
            Title = "";
        }
    
        public List<QuestionModel> PopulateQuestions()
        {
            List<QuestionModel> questions = new List<QuestionModel>();
            var documents = service.FetchQuestions("operators");
            foreach (QuestionModel qs in documents)
            {
                OperatorQuestions.Add(qs);
                questions.Add(qs);
            }

            return questions;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //[RelayCommand]
        //public static async void StartForum()
        //{
        //    await Shell.Current.GoToAsync("///Forum");

        //}
        //[RelayCommand]
        //public static async void StartTest()
        //{
        //    await Shell.Current.GoToAsync("///Test");

        //}

        //[RelayCommand]
        //public static async void StartAbout()
        //{
        //    await Shell.Current.GoToAsync("///About");
        //}
        //[RelayCommand]
        //public static async void StartMain()
        //{
        //    await Shell.Current.GoToAsync("///Main");
        //}

        //[RelayCommand]
        //public static async void StartSummary()
        //{
        //    await Shell.Current.GoToAsync("///Summary");
        //}

    }
    
}