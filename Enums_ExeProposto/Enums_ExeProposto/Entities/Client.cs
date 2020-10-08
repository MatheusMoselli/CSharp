using System;
using System.Collections.Generic;
using System.Text;

namespace Enums_ExeProposto.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append(Name).Append(", (").Append(BirthDate.ToString("dd/MM/yyyy")).Append(") - ").Append(Email);

            return txt.ToString();
        }
    }
}
