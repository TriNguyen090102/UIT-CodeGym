using UIT_CodeGym.ViewModels;
using CommunityToolkit.Maui.Views;

namespace UIT_CodeGym.MVVM.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}