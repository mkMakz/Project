using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus;

namespace Campus.Modules.Menus
{
    public class AdminMenu
    {
        public void AdMenu(AdminService service)
        {
            

            Console.WriteLine("========== Menu ==========");
                Console.WriteLine();
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Print list of students");
                Console.WriteLine("3. Exit");

                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine();

                Console.Write("Choose the position: ");
                int choice = int.Parse(Console.ReadLine());
        Console.Clear();
                Console.WriteLine();

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Add student:");
                    service.CreateStudent();
                    Console.WriteLine(); ;
                    break;

                case 2:
                    Console.WriteLine("Printing list of students");
                    service.PrintStudent();
                    Console.WriteLine();
                    break;

                case 3:
                    break;

            }

            }

    }
}
