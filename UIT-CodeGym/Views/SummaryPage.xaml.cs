using UIT_CodeGym.database;
using UIT_CodeGym.Models;
using UIT_CodeGym.ViewModels;

namespace UIT_CodeGym.MVVM.Views;

public partial class SummaryPage : ContentPage
{
    string title;
    List<UserRecordModel> record = new List<UserRecordModel>();
    public SummaryPage(SummaryPageVM vm)
	{
		InitializeComponent();
		record = vm.PopulateUsersRecord();
        title = vm.Title;
        BindingContext = vm;
	}
}