using UIT_CodeGym.ViewModels;
namespace UIT_CodeGym.MVVM.Views;

public partial class QuizPage : ContentPage
{
    private Button[] answerButtons;
    public QuizPage(QuizPageVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
        vm.PopulateOperatorQuestions();

    }
    private void OnButtonClicked(object sender, System.EventArgs e)
    {
        Button clickedButton = (Button)sender;
        clickedButton.BackgroundColor = Color.FromHex("#E1EEBC");
        foreach (var button in answerButtons)
        {
            if (button != clickedButton)
            {
                button.BackgroundColor = Color.FromHex("#ffffff");
            }
        }

    }

    void sendbutton_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
