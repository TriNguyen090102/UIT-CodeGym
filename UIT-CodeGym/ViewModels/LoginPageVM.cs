using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Realms.Sync;
using UIT_CodeGym.database;
using UIT_CodeGym.Services;

namespace UIT_CodeGym.MVVM.ViewModels
{
    public partial class LoginPageVM : BaseViewModel
    {
        public LoginPageVM()
        {
            StudentID = "";
            Password = "";
        }
        [ObservableProperty]
        string studentID;

        [ObservableProperty]
        string password;
        [RelayCommand]
        async void CreateAccount()
        {
            try
            {
                await App.RealmApp.EmailPasswordAuth.RegisterUserAsync(StudentID, Password);

                await Login();

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error creating account!", "Error: " + ex.Message, "OK");
            }
        }

        [RelayCommand]
        public async Task Login()
        {
            try
            {
                var user = await App.RealmApp.LogInAsync(Credentials.EmailPassword(StudentID, Password));
                var service = new QuestionsService();
                var isAdmin = service.IsAdmin(StudentID);
                if (user != null && !isAdmin)
                {
                    await Shell.Current.GoToAsync("///Main");
                    AppProperties.UserName = StudentID;
                    StudentID = "";
                    Password = "";
                }
                else if(user != null && isAdmin)
                {
                    //await Shell.Current.GoToAsync("///Forum");
                    await Shell.Current.GoToAsync("///AddQuestions");
                    AppProperties.UserName = StudentID;
                    StudentID = "";
                    Password = "";
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error Logging In", ex.Message, "OK");
            }

        }

    }
}
    

