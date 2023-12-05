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

	

	protected override void OnSizeAllocated (double pageWidth, double pageHeight) {
    base.OnSizeAllocated(pageWidth, pageHeight);
    const double aspectRatio = 1600 / 1441.0; // Aspect ratio of the original image
    backgroundImage.WidthRequest = Math.Max(pageHeight * aspectRatio, pageWidth);
}
}