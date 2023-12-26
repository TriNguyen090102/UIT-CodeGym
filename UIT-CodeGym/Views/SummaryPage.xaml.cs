using UIT_CodeGym.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using SkiaSharp.Views;
namespace UIT_CodeGym.MVVM.Views;

public partial class SummaryPage : ContentPage
{
	public SummaryPage(SummaryPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    
}