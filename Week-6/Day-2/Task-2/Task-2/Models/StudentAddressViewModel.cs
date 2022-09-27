using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class StudentAddressViewModel
    {
        public StudentViewModel StudentData { get; set; }
        public AddressViewModel Address { get; set; }

    }
}
