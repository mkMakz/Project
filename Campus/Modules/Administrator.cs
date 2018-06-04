using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Modules
{
    public class Administrator
    {
        

       
        public string FullName { get; set; }
       
        public string Login { get; set; }
        public string Password { get; set; }
        


        public Administrator()
        {
            FullName = "VasyaAdmin";
            Login = "Root";
            Password = "Admin";
        }

        public void PrintAdmin()
        {
            Console.WriteLine($"Name {FullName}\n Login {Login}\n Password {Password}\n ");

        }

       
    }
}
