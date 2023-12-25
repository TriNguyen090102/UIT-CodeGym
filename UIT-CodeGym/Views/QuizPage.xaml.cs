using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.ViewModels;
namespace UIT_CodeGym.MVVM.Views;

public partial class QuizPage : ContentPage
{
    Button previousButton;
    List<char> answer = Enumerable.Repeat('0', 10).ToList();
    QuestionsService service = new QuestionsService();
    List<QuestionModel> questions = new List<QuestionModel>();

    public QuizPage(QuizPageVM vm)
    {
        InitializeComponent();
        questions = vm.PopulateOperatorQuestions();
        BindingContext = vm;

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

    void Question1_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion1.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
            }
        }
        Button clickedButton = (Button)sender;
        if (clickedButton.BackgroundColor == Color.FromHex("#E1EEBC"))
        {
            clickedButton.BackgroundColor = Color.FromHex("#FFFFFF");
        }
        else
        {
            clickedButton.BackgroundColor = Color.FromHex("#E1EEBC");
        }
        

    }

    void Question2_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion2.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
            }
        }
        Button clickedButton = (Button)sender;
        if (clickedButton.BackgroundColor == Color.FromHex("#E1EEBC"))
        {
            clickedButton.BackgroundColor = Color.FromHex("#FFFFFF");
        }
        else
        {
            clickedButton.BackgroundColor = Color.FromHex("#E1EEBC");
        }
        

    }
}
