using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class ForumPage : ContentPage
{
	public ForumPage(ForumPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}