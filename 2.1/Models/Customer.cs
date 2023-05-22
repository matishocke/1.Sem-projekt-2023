using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.Models
{
    public class Customer
    {
        public Customer(int cprNr, string firstname, string lastname,
                        int mobilnumber, string email, string address)
        {
            this.CprNr = cprNr;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.MobileNumber = mobilnumber;
            this.Email = email;
            this.Address = address;
        }
        public int CprNr { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
