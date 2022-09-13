using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Domain.Interfaces
{
    interface Ivalidate
    {
        void ValidateAdmin(string name, string pass);
        bool ValidateEmployee();
    }
}
