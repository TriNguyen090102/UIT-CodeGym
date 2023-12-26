using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.ViewModels;
using System.Linq;
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
                if (button.Text == questions[1].a && questions[1].correct_answer == "a")
                {
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
        else if (clickedButton.Text == questions[1].b)
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

    void Question3_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion3.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[2].a && questions[2].correct_answer == "a")
                {
                    correctButton[2] = button;
                }
                if (button.Text == questions[2].b && questions[2].correct_answer == "b")
                {
                    correctButton[2] = button;
                }
                if (button.Text == questions[2].c && questions[2].correct_answer == "c")
                {
                    correctButton[2] = button;
                }
                if (button.Text == questions[2].d && questions[2].correct_answer == "d")
                {
                    correctButton[2] = button;
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

        if (clickedButton.Text == questions[2].a)
        {
            answer[2] = 'a';

        }
        else if (clickedButton.Text == questions[2].b)
        {
            answer[2] = 'b';

        }
        else if (clickedButton.Text == questions[2].c)
        {
            answer[2] = 'c';

        }
        else if (clickedButton.Text == questions[2].d)
        {
            answer[2] = 'd';
        }
        selectedButton[2] = clickedButton;
    }

    void Question4_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion4.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[3].a && questions[3].correct_answer == "a")
                {
                    correctButton[3] = button;
                }
                if (button.Text == questions[3].b && questions[3].correct_answer == "b")
                {
                    correctButton[3] = button;
                }
                if (button.Text == questions[3].c && questions[3].correct_answer == "c")
                {
                    correctButton[3] = button;
                }
                if (button.Text == questions[3].d && questions[3].correct_answer == "d")
                {
                    correctButton[3] = button;
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

        if (clickedButton.Text == questions[3].a)
        {
            answer[3] = 'a';

        }
        else if (clickedButton.Text == questions[3].b)
        {
            answer[3] = 'b';

        }
        else if (clickedButton.Text == questions[3].c)
        {
            answer[3] = 'c';

        }
        else if (clickedButton.Text == questions[3].d)
        {
            answer[3] = 'd';
        }
        selectedButton[3] = clickedButton;
    }

    void Question5_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion5.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[4].a && questions[4].correct_answer == "a")
                {
                    correctButton[4] = button;
                }
                if (button.Text == questions[4].b && questions[4].correct_answer == "b")
                {
                    correctButton[4] = button;
                }
                if (button.Text == questions[4].c && questions[4].correct_answer == "c")
                {
                    correctButton[4] = button;
                }
                if (button.Text == questions[4].d && questions[4].correct_answer == "d")
                {
                    correctButton[4] = button;
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

        if (clickedButton.Text == questions[4].a)
        {
            answer[4] = 'a';

        }
        else if (clickedButton.Text == questions[4].b)
        {
            answer[4] = 'b';

        }
        else if (clickedButton.Text == questions[4].c)
        {
            answer[4] = 'c';

        }
        else if (clickedButton.Text == questions[4].d)
        {
            answer[4] = 'd';
        }
        selectedButton[4] = clickedButton;
    }

    void Question6_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion6.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[5].a && questions[5].correct_answer == "a")
                {
                    correctButton[5] = button;
                }
                if (button.Text == questions[5].b && questions[5].correct_answer == "b")
                {
                    correctButton[5] = button;
                }
                if (button.Text == questions[5].c && questions[5].correct_answer == "c")
                {
                    correctButton[5] = button;
                }
                if (button.Text == questions[5].d && questions[5].correct_answer == "d")
                {
                    correctButton[5] = button;
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

        if (clickedButton.Text == questions[5].a)
        {
            answer[5] = 'a';

        }
        else if (clickedButton.Text == questions[5].b)
        {
            answer[5] = 'b';

        }
        else if (clickedButton.Text == questions[5].c)
        {
            answer[5] = 'c';

        }
        else if (clickedButton.Text == questions[5].d)
        {
            answer[5] = 'd';
        }
        selectedButton[5] = clickedButton;
    }

    void Question7_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion7.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[6].a && questions[6].correct_answer == "a")
                {
                    correctButton[6] = button;
                }
                if (button.Text == questions[6].b && questions[6].correct_answer == "b")
                {
                    correctButton[6] = button;
                }
                if (button.Text == questions[6].c && questions[6].correct_answer == "c")
                {
                    correctButton[6] = button;
                }
                if (button.Text == questions[6].d && questions[6].correct_answer == "d")
                {
                    correctButton[6] = button;
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

        if (clickedButton.Text == questions[6].a)
        {
            answer[6] = 'a';

        }
        else if (clickedButton.Text == questions[6].b)
        {
            answer[6] = 'b';

        }
        else if (clickedButton.Text == questions[6].c)
        {
            answer[6] = 'c';

        }
        else if (clickedButton.Text == questions[6].d)
        {
            answer[6] = 'd';
        }
        selectedButton[6] = clickedButton;
    }

    void Question8_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion8.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[7].a && questions[7].correct_answer == "a")
                {
                    correctButton[7] = button;
                }
                if (button.Text == questions[7].b && questions[7].correct_answer == "b")
                {
                    correctButton[7] = button;
                }
                if (button.Text == questions[7].c && questions[7].correct_answer == "c")
                {
                    correctButton[7] = button;
                }
                if (button.Text == questions[7].d && questions[7].correct_answer == "d")
                {
                    correctButton[7] = button;
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

        if (clickedButton.Text == questions[7].a)
        {
            answer[7] = 'a';

        }
        else if (clickedButton.Text == questions[7].b)
        {
            answer[7] = 'b';

        }
        else if (clickedButton.Text == questions[7].c)
        {
            answer[7] = 'c';

        }
        else if (clickedButton.Text == questions[7].d)
        {
            answer[7] = 'd';
        }
        selectedButton[7] = clickedButton;
    }

    void Question9_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion9.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[8].a && questions[8].correct_answer == "a")
                {
                    correctButton[8] = button;
                }
                if (button.Text == questions[8].b && questions[8].correct_answer == "b")
                {
                    correctButton[8] = button;
                }
                if (button.Text == questions[8].c && questions[8].correct_answer == "c")
                {
                    correctButton[8] = button;
                }
                if (button.Text == questions[8].d && questions[8].correct_answer == "d")
                {
                    correctButton[8] = button;
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

        if (clickedButton.Text == questions[8].a)
        {
            answer[8] = 'a';

        }
        else if (clickedButton.Text == questions[8].b)
        {
            answer[8] = 'b';

        }
        else if (clickedButton.Text == questions[8].c)
        {
            answer[8] = 'c';

        }
        else if (clickedButton.Text == questions[8].d)
        {
            answer[8] = 'd';
        }
        selectedButton[8] = clickedButton;
    }

    void Question10_Handle_Clicked(object sender, System.EventArgs e)
    {
        foreach (View childView in ButtonQuestion10.Children.Cast<View>())
        {
            if (childView is Button button)
            {
                button.BackgroundColor = Color.FromHex("#FFFFFF");
                if (button.Text == questions[9].a && questions[9].correct_answer == "a")
                {
                    correctButton[9] = button;
                }
                if (button.Text == questions[9].b && questions[9].correct_answer == "b")
                {
                    correctButton[9] = button;
                }
                if (button.Text == questions[9].c && questions[9].correct_answer == "c")
                {
                    correctButton[9] = button;
                }
                if (button.Text == questions[9].d && questions[9].correct_answer == "d")
                {
                    correctButton[9] = button;
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

        if (clickedButton.Text == questions[9].a)
        {
            answer[9] = 'a';

        }
        else if (clickedButton.Text == questions[9].b)
        {
            answer[9] = 'b';

        }
        else if (clickedButton.Text == questions[9].c)
        {
            answer[9] = 'c';

        }
        else if (clickedButton.Text == questions[9].d)
        {
            answer[9] = 'd';
        }
        selectedButton[9] = clickedButton;
    }
    void OnFinish(object sender, System.EventArgs e)
    {
        for (int i = 0; i < 10; i++)
        {
            if (answer[i].ToString() != questions[i].correct_answer)
            {
                selectedButton[i].BackgroundColor = Color.FromHex("#F34B4B");
            }
            correctButton[i].BackgroundColor = Color.FromHex("#46C579");
        }
        foreach (View childView in SummaryBtn.Children.Cast<View>())
        {
            if (childView is Button button)
                button.IsEnabled = false;
        }
        SummaryBtn.isEnabled = true;
    }
    
}
