using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class PracticeImmediatePage : ContentPage
{
	public PracticeImmediatePage(PracticeImmediatePageVM vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}