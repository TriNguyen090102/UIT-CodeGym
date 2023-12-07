using CommunityToolkit.Maui.Views;
using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class IntroductionPage : ContentPage
{
	public IntroductionPage(IntroductionVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}