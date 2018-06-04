using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campus;
using Campus.Modules;
using Campus.Modules.Menus;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Students st = new Students();
            StudentService sts = new StudentService();
            AdminMenu am = new AdminMenu();
            CompanyMenu ComMeny = new CompanyMenu();
            StudentMenu StsMenu = new StudentMenu();

            AdminService adm = new AdminService();
            adm.GenerStudents();
            Company com = new Company();
            CompanyService comser = new CompanyService();
            comser.GenerateCompanies();

            comser.FindCandidate(ref adm.st);
            comser.PrintCompany();
            comser.RegistCompany();


            //adm.PrintStudent();


            /*while (true)
            {

                Console.WriteLine("========== Menu ==========");
                Console.WriteLine();
                Console.WriteLine("1. Administrator");
                Console.WriteLine("2. Student");
                Console.WriteLine("3.Company");
                Console.WriteLine("4. Exit");

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
                        Console.WriteLine("Administrator");
                        am.AdMenu(adm);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Student");
                        StsMenu.StMenu(adm);
                        break;

                    case 3:
                        Console.WriteLine("Company");
                        ComMeny.ComMenu(adm);
                        Console.WriteLine();
                        break;
                    case 4:
                        break;

                }

            }*/
         


        }
    }
}
