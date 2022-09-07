using System;
using System.Collections.Generic;
using System.Text;
using Task_2_ATM_.Domain.Enums;

namespace Task_2_ATM_.Domain.Entities
{
    public class Transaction
    {
        public long TransactionId { get; set; }
        public long UserBankAccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Descriprion { get; set; }
        public Decimal TransactionAmount { get; set; }
    }
}
