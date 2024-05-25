using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Models
{
    public class CreateUser
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Surname { get; set; }
        public required string Name { get; set; }
        public required string Middlename { get; set; }
    }
}
