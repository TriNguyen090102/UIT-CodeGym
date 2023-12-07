﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Realms.Sync;





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

                if (user != null)
                {
                    await Shell.Current.GoToAsync("///Main");
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
    
