using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Modules
{
    public enum Faculty { Economy = 1, Math, Phisics, Management }
    public class Students
    {
        private string _fullName;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "");
            }
        }
        public int ID { get; set; }
        public Faculty Faculty { get; set; }
        public int Course { get; set; }
        public DateTime RegDate { get; set; }
        public Resume Resume { get; set; }

        public Students()
        {
            this.Resume = new Resume();

        }
        public void PrintStudent()
        {
            Console.WriteLine($"Name {FullName}\n ID {ID}\n Faculty {Faculty}\n Course {Course}\n Regist date {RegDate}\n\n Resume:\n" +
                    $" Name:  {Resume.FullName}\n Faculty {Resume.Faculty}\n " +
                    $"Course: {Resume.Course}\n Average mark: {Resume.AvgMark}\n" +
                    $"Work exp: {Resume.WorkExpirience}\n ");
        }

    }
}
