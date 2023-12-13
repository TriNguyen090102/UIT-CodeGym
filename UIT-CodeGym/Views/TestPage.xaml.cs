using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class TestPage : ContentPage
{
	public TestPage(TestPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}