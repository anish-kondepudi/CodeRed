﻿using Xamarin.Forms;

namespace CodeRed.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignUpCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            SignUpCommand = new Command(OnSignUpClicked);
        }

        private void OnLoginClicked()
        {
            // Logic for login button click
        }

        private void OnSignUpClicked()
        {
            // Logic for sign up button click
        }
    }
}