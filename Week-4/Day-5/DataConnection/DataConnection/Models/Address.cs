using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataConnection.Models
{
    public class Address : BaseModel
    {

        public Address()
        {

        }

        public Address(SqlDataReader reader)
        {

        }

        public int AddressId { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string ProvinceState { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

    }
}
