using UIT_CodeGym.ViewModels;
namespace UIT_CodeGym.MVVM.Views;

public partial class QuizPage : ContentPage
{
    Button previousButton;
    public QuizPage(QuizPageVM vm)
    {
        InitializeComponent();
        BindingContext = vm;
        vm.PopulateOperatorQuestions();

    }
    void Button_ClickedA(System.Object sender, System.EventArgs e)
    {
        Button clickedButton = (Button)sender;
        clickedButton.BackgroundColor = Color.FromHex("#E1EEBC");
        if (previousButton!=null)
        {
            previousButton.BackgroundColor = Color.FromHex("#FFFFFF");
        }
        previousButton = clickedButton;
    }
    void Button_ClickedB(System.Object sender, System.EventArgs e)
    {
        Button clickedButton = (Button)sender;
        clickedButton.BackgroundColor = Color.FromHex("#E1EEBC");
        if (previousButton != null)
        {
            previousButton.BackgroundColor = Color.FromHex("#FFFFFF");
        }
        previousButton = clickedButton;
    }
    void Button_ClickedC(System.Object sender, System.EventArgs e)
    {
        Button clickedButton = (Button)sender;
        clickedButton.BackgroundColor = Color.FromHex("#E1EEBC");
        if (previousButton != null)
        {
            previousButton.BackgroundColor = Color.FromHex("#FFFFFF");
        }
        previousButton = clickedButton;
    }
    void Button_ClickedD(System.Object sender, System.EventArgs e)
    {
        Button clickedButton = (Button)sender;
        clickedButton.BackgroundColor = Color.FromHex("#E1EEBC");
        if (previousButton != null)
        {
            previousButton.BackgroundColor = Color.FromHex("#FFFFFF");
        }
        previousButton = clickedButton;
    }

}
