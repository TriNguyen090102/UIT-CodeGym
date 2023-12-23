
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Maui.Controls;
using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.MVVM.ViewModels;
using System.Windows.Input;

namespace UIT_CodeGym.ViewModels
{

    public partial class QuizPageVM : BaseViewModel
    {
        public ObservableCollection<QuestionModel> OperatorQuestions { get; set; }
        public ObservableCollection<QuestionModel> PointerQuestions { get; set; }
        public ObservableCollection<QuestionModel> SwitchQuestions { get; set; }
        public int countCorrectAnswer= 0;
        public Command ButtonClickACommand { get; set; }
        public Command ButtonClickBCommand { get; set; }
        public Command ButtonClickCCommand { get; set; }
        public Command ButtonClickDCommand { get; set; }
        public Command SendButtonClickCommand { get; set; }

        private Button _selectedButton, _previousButton;
        private QuestionModel _currentQuestion;
        public QuizPageVM()
        {
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
                
                _selectedButton = null;
                _currentQuestion = qs;
                ButtonClickACommand = new Command<Button>(ButtonClicked);
                ButtonClickBCommand = new Command<Button>(ButtonClicked);
                ButtonClickCCommand = new Command<Button>(ButtonClicked);
                ButtonClickDCommand = new Command<Button>(ButtonClicked);
                qs.buttonClicked = new Button[] {};
                SendButtonClickCommand = new Command(SendButtonClicked);
            }
        }

        private void ButtonClicked(Button button)
        {
            button.BackgroundColor = Color.FromHex("#E1EEBC");
            if (_previousButton != null)
            {
                _previousButton.BackgroundColor = Color.FromHex("#FFFFFF");
                _previousButton = button;
            }
            _currentQuestion.SelectedAnswer = button.Text;
        }

        private void SendButtonClicked()
        {
            if (_currentQuestion != null)
            {
                if (_currentQuestion.SelectedAnswer == _currentQuestion.correct_answer)
                {
                    _selectedButton.BackgroundColor = Color.FromHex("#46C579");
                    countCorrectAnswer += 1;
                }
                else
                {
                    _selectedButton.BackgroundColor = Color.FromHex("#F34B4B");
                }
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



    }
}