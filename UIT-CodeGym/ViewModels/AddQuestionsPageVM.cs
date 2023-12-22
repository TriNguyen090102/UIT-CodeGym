using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.MVVM.ViewModels;
using UIT_CodeGym.Services;

namespace UIT_CodeGym.ViewModels
{
    public partial class AddQuestionsPageVM : BaseViewModel
    {
        public ObservableCollection<DataModel> QuestionCatagory { get; set; }
        public ObservableCollection<DataModel> CorrectAnswerList { get; set; }


        private DataModel _selectedQuestionCategory;
        private DataModel _selectedCorrectAnswer;

        [ObservableProperty]
         string question;
   
        [ObservableProperty]
        string answerA;
        [ObservableProperty]
        string answerB;

        [ObservableProperty]
        string answerC;

        [ObservableProperty]
        string answerD;





        //private string _correctAnswer;

        public AddQuestionsPageVM()
        {
            QuestionCatagory = new ObservableCollection<DataModel> {
                new DataModel() { Name = "Operators", ID = 0 },
                new DataModel() { Name = "Switch", ID = 1 },
                new DataModel() { Name = "Pointer", ID = 2 },
                new DataModel() { Name = "Data Types", ID = 3 },
                new DataModel() { Name = "Math", ID = 4 },
                new DataModel() { Name = "Variables", ID = 5 },
                new DataModel() { Name = "Condition", ID = 6 },
                new DataModel() { Name = "Switch", ID = 7 },
                new DataModel() { Name = "For Loop", ID = 8 },
                new DataModel() { Name = "While Loop", ID = 8 }

            };

            CorrectAnswerList = new ObservableCollection<DataModel>
            {
                new DataModel() { Name = "A", ID = 0 },
                new DataModel() { Name = "B", ID = 1 },
                new DataModel() { Name = "C", ID = 2 },
                new DataModel() { Name = "D", ID = 3 },
            };
            AnswerA = "";
            AnswerB = "";
            AnswerC = "";
            AnswerD = "";
            Question = "";
        }



        public DataModel SelectedQuestionCategory
        {
            get => _selectedQuestionCategory;
            set
            {
                _selectedQuestionCategory = value;
                // Perform actions based on the selected item
                //Console.WriteLine("Selected category: {0}", value.Name);
               
            }
        }
        

        public DataModel SelectedCorrectAnswer
        {
            get => _selectedCorrectAnswer;
            set
            {
                _selectedCorrectAnswer = value;
            }
        }


        
        [RelayCommand]
        public static async void LogOut()
        {
            await Shell.Current.GoToAsync("///Introduction");
            AppProperties.UserName = "";
        }
        [RelayCommand]
        public async void AddQuestionsToDatabase()
        {
            string title = _selectedQuestionCategory.Name.ToLower();
            if(title == "" || title == null || Question == "" || AnswerA == "" || AnswerB == "" || AnswerC == "" || AnswerD == "" || _selectedCorrectAnswer.Name.ToLower() == "" || _selectedCorrectAnswer ==null)
            {
                Shell.Current.DisplayAlert("Empty Fields", "Please fill in all required fields.", "OK");
            }
            else
            {
                QuestionModel newQuestion = new()
                {
                    title = title,
                    question = Question,
                    a = AnswerA,
                    b = AnswerB,
                    c = AnswerC,
                    d = AnswerD,
                    correct_answer = _selectedCorrectAnswer.Name.ToLower(),
                };

                QuestionsService service = new QuestionsService();
                if (await service.InsertQuestionToQuestionDB(newQuestion))
                {
                    Shell.Current.DisplayAlert("Insert Successful", "", "OK");
                }
                else
                {
                    Shell.Current.DisplayAlert("Insert Faile", "Something wrong happened, please try again", "OK");
                }

                AnswerA = "";
                AnswerB = "";
                AnswerC = "";
                AnswerD = "";
                Question = "";
            }
          
        }
    }
}
