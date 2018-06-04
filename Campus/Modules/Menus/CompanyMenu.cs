using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus;

namespace Campus.Modules.Menus
{
    public class CompanyMenu
    {

        public void ComMenu(AdminService admin)
        {
            CompanyService company = new CompanyService();

            Console.WriteLine("========== Menu ==========");
            Console.WriteLine();
            Console.WriteLine("1. Registration");
            Console.WriteLine("2. Find candidates");
            Console.WriteLine("3. Exit");

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
                    Console.WriteLine("Registration:");
                    company.RegistCompany();
                    Console.WriteLine(); ;
                    break;

                case 2:
                    Console.WriteLine("Find candidates");
                    company.FindCandidate(ref admin.st);
                    Console.WriteLine();
                    break;

                case 3:
                    break;

            }

        }
    }
}
