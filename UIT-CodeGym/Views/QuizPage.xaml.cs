using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.ViewModels;
namespace UIT_CodeGym.MVVM.Views;

public partial class QuizPage : ContentPage
{
    Button previousButton;
    List<char> answer = Enumerable.Repeat('0', 10).ToList();
    QuestionsService service = new QuestionsService();
    List<Button> selectedButton = new List<Button>();
    List<Button> correctButton = new List<Button>();

    List<QuestionModel> questions = new List<QuestionModel>();

    public QuizPage(QuizPageVM vm)
    {
        InitializeComponent();
        questions = vm.PopulateOperatorQuestions();
        BindingContext = vm;
        for (int i = 0; i < 10; i++)
        {
            selectedButton.Add(null);  // Add null as the initial value
            correctButton.Add(null);
        }
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
                if (button.Text == questions[0].a && questions[0].correct_answer == "a")
                {
                    correctButton[0] = button;
                }
                if (button.Text == questions[0].b && questions[0].correct_answer == "b")
                {
                    correctButton[0] = button;
                }
                if (button.Text == questions[0].c && questions[0].correct_answer == "c")
                {
                    correctButton[0] = button;
                }
                if (button.Text == questions[0].d && questions[0].correct_answer == "d")
                {
                    correctButton[0] = button;
                }
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


        if (clickedButton.Text == questions[0].a)
        {
            answer[0] = 'a';
        }
        else if (clickedButton.Text == questions[0].b)
        {
            answer[0] = 'b';
        }
        else if (clickedButton.Text == questions[0].c)
        {
            answer[0] = 'c';
        }
        else if (clickedButton.Text == questions[0].d)
        {
            answer[0] = 'd';
        }
        selectedButton[0] = clickedButton;
    }

    void Question2_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion2.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if(button.Text == questions[1].a && questions[1].correct_answer == "a") {
                    correctButton[1] = button;
                }
                if (button.Text == questions[1].b && questions[1].correct_answer == "b")
                {
                    correctButton[1] = button;
                }
                if (button.Text == questions[1].c && questions[1].correct_answer == "c")
                {
                    correctButton[1] = button;
                }
                if (button.Text == questions[1].d && questions[1].correct_answer == "d")
                {
                    correctButton[1] = button;
                }
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

        if (clickedButton.Text == questions[1].a)
        {
            answer[1] = 'a';
          
        }
        else if(clickedButton.Text == questions[1].b)
        {
            answer[1] = 'b';
           
        }
        else if (clickedButton.Text == questions[1].c)
        {
            answer[1] = 'c';
           
        }
        else if (clickedButton.Text == questions[1].d)
        {
            answer[1] = 'd';
        }
        selectedButton[1] = clickedButton;
    }

    void OnFinish(object sender, System.EventArgs e)
    {
        for (int i = 0; i < 2; i++)
        {
            if(answer[i].ToString() != questions[i].correct_answer)
            {
                selectedButton[i].BackgroundColor = Color.FromHex("#db3939");
            }
            correctButton[i].BackgroundColor = Color.FromHex("#E1EEBC");
        }
    }
}
