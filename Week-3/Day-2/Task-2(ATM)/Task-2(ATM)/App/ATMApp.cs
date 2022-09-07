using System;
using System.Collections.Generic;
using System.Threading;
using Task_2_ATM_.Domain.Entities;
using Task_2_ATM_.Domain.Interfaces;
using Task_2_ATM_.UI;

namespace Task_2_ATM_
{
    public class ATMApp : IUserLogin
    {
        private List<UserAccount> UserAccountList;
        private UserAccount selectedAccount;


        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
            while(isCorrectLogin == false)
            {
                UserAccount inputAccount = AppScreen.UserLoginForm();
                AppScreen.LoginProgress();
                foreach(UserAccount account in UserAccountList)
                {
                    selectedAccount = account;
                    if (inputAccount.cardNumber.Equals(selectedAccount.cardNumber))
                    {
                        selectedAccount.totalLogin++;
                        if (inputAccount.cardPin.Equals(selectedAccount.cardPin))
                        {
                            selectedAccount = account;

                            if(selectedAccount.isLocked || selectedAccount.totalLogin > 3)
                            {
                                //Print a lock message
                                AppScreen.PrintLockScreen();
                            }
                            else
                            {
                                selectedAccount.totalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }
                        }
                    }
                    if (isCorrectLogin == false)
                    {
                        Utility.PrintMessage("\nInvalid card number or PIN.", false);
                        selectedAccount.isLocked = selectedAccount.totalLogin == 3;
                        if (selectedAccount.isLocked)
                        {
                            AppScreen.PrintLockScreen();
                        }
                    }
                    Console.Clear();
                }
            }
            
            
        }


        public void Welcome()
        {
            Console.WriteLine($"Welcome back, {selectedAccount.fullName}");
        }

        

        public void InitializedData()
        {
            UserAccountList = new List<UserAccount>
            {
                new UserAccount {Id=1,fullName = "Mohit",accountNumber=3789287981,cardNumber=8234769876224,cardPin=2332,accountBalance=56000,isLocked=false}
            };
        }

    }
}
