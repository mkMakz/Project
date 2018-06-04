using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus.Modules.Menus
{
    public class StudentMenu
    {
        public void StMenu(AdminService admin)
        {
            StudentService stds = new StudentService();

            Console.WriteLine("========== Menu ==========");
            Console.WriteLine();
            Console.WriteLine("1. Change information");
            Console.WriteLine("2. Exit");

            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.Write("Choose the position: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Change information:");
                    stds.UpdateStudentInfo(ref admin.st);
                    Console.WriteLine(); ;
                    break;

                case 2:
                    break;
            }

        }
    }
}
