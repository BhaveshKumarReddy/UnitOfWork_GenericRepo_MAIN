using System;
using System.Collections.Generic;

namespace UnitOfWork_GenericRepo_MAIN.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
