using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15U03Ex03
{
    internal class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }

        public Contact(string name,long phone,string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
