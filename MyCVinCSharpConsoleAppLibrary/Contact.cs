using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCVinCSharpConsoleAppLibrary
{
    public class Contact
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public Contact(string phone, string email)
        {
            Phone = phone;
            Email = email;
        }
        public string MyContact()
        {
            return $"Here is my phone: {Phone} and email: {Email}";
        }
    }
}
