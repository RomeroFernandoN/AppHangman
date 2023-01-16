using System;
using System.Collections.Generic;
using System.Text;

namespace AppAhorcado.AppAhorcadoBackend.Domain
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public int Points { get; set; }
        public string Country { get; set; }
    }
}
