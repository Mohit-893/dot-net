using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_ATM_.Domain.Entities
{
    public class UserAccount
    {
        public int Id { get; set; }
        public long cardNumber { get; set; }
        public int cardPin { get; set; }
        public long accountNumber { get; set; }
        public string fullName { get; set; }
        public decimal accountBalance { get; set; }
        public int totalLogin { get; set; }
        public bool isLocked { get; set; }
    }
}
