using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_ATM_.Domain.Interfaces
{
    public interface IUserAccountActions
    {
        void CheckBalance();
        void PlaceDeposit();
        void MakeWithdrawal();

    }
}
