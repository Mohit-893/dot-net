using System;
using System.Collections.Generic;
using System.Text;
using Task_2_ATM_.Domain.Enums;

namespace Task_2_ATM_.Domain.Interfaces
{
    public interface ITransaction
    {
        void InsertTransaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string _desc);
        void ViewTransaction();
    }
}
