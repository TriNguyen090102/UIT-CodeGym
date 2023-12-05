using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}