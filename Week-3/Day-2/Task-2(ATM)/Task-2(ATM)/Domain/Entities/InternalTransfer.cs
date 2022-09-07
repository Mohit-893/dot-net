using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_ATM_.Domain.Entities
{
    public class InternalTransfer
    {
        public decimal TransferAmount { get; set; }
        public long ReciepeintBankAccountNumber { get; set; }
        public string RecipientBankAccountName { get; set; }
    }
}
