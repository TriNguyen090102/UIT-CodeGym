using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class PracticeBeginnerPage : ContentPage
{
	public PracticeBeginnerPage(PracticeBeginnerPageVM vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}