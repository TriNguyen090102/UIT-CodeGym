using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class PracticeAdvancedPage : ContentPage
{
	public PracticeAdvancedPage(PracticeAdvancedPageVM vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}