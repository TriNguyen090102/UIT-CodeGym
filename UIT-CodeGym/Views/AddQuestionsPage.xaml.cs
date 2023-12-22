using Syncfusion.Maui.Inputs;
using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class AddQuestionsPage : ContentPage
{
	public AddQuestionsPage(AddQuestionsPageVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
	}
}