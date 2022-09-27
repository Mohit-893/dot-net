using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_2.Models
{
    interface ICombineData
    {
        public StudentAddressViewModel GetDatabyRollNo(int RollNo);
    }
}
