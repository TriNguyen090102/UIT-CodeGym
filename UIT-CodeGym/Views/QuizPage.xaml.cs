using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class QuizPage : ContentPage
{
    public QuizPage(QuizPageVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}