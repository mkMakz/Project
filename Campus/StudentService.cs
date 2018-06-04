using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Campus.Modules;
using GeneratorName;

namespace Campus
{
    public class StudentService
    {
        private Random r = new Random();
      
        

        public void UpdateStudentInfo(ref List<Students> st)
        {
            Console.WriteLine("Enter your ID:");
            int Id = Int32.Parse(Console.ReadLine());
            foreach (Students item in st)
            {
                if (Id == item.ID)
                {
                    Console.WriteLine("Enter your name:");
                    item.FullName = Console.ReadLine();
                    Console.WriteLine("Enter your Course:");
                    item.Course = Int32.Parse(Console.ReadLine());
                    item.Resume.FullName = item.FullName;
                    item.Resume.Course = item.Course;
                    item.Resume.AvgMark = Int32.Parse(Console.ReadLine());
                    item.Resume.WorkExpirience = Int32.Parse(Console.ReadLine());
                }
            }
        }

      
    }
}



    

