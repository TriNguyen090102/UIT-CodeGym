using CommunityToolkit.Maui.Views;
using UIT_CodeGym.MVVM.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}