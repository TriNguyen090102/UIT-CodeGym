using Microsoft.Maui.Controls.Platform;
using UIT_CodeGym.database;
using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class QuizPage : ContentPage
{
    public QuizPage(QuizPageVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
        vm.PopulateOperatorQuestions();
    }
}