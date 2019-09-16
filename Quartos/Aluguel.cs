using System;
using System.Collections.Generic;
using System.Text;

namespace Quartos
{
    class Aluguel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Aluguel(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
