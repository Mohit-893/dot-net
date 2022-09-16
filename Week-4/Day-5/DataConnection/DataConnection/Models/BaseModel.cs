using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataConnection.Models
{
    public class BaseModel
    {
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public SqlDataReader DataReader { get; set; }

    }
}
