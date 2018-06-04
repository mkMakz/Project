using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Modules
{
    public enum Companies { Apple = 1, Google, Amazon, Twitch, Kcell, Twitter, RP }
    public class Company
    {
       
        public string CompanyName { get; set; }
        public string Password { get; set; }
        public int AvgMark { get; set; }
        public int WorkExperience { get; set; }

        


    }
}
