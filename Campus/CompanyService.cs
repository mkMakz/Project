using Campus.Modules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Campus
{
    public class CompanyService
    {
        private Random r = new Random();
        private string path = @"Companies.xml";
        public List<Company> comp = new List<Company>();

        public void GenerateCompanies()
        {
            for (int i = 1; i < 10; i++)
            {
                Company com = new Company();
                com.CompanyName = ((Companies)r.Next(1, 8)).ToString();
                com.Password = "com" + i.ToString();
                com.AvgMark = r.Next(80, 97);
                com.WorkExperience = r.Next(0, 4);
                comp.Add(com);
                addStudentToXml(com);
            }
        }

        public void RegistCompany()
        {
            Company company = new Company();
            Console.WriteLine("Enter name of company:");
            company.CompanyName = Console.ReadLine();
            Console.WriteLine("Enter enter a password:");
            company.Password = Console.ReadLine();
            Console.WriteLine("Enter requirement mark:");
            company.AvgMark = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter work experience:");
            company.WorkExperience = Int32.Parse(Console.ReadLine());
            comp.Add(company);
            addStudentToXml(company);
            Console.WriteLine("Company was created successfuly");

        }


        private void addStudentToXml(Company com)
        {
            XmlDocument doc = getDocument();
            XmlComment xcom;
            XmlElement elem = doc.CreateElement("Company");

            XmlElement Name = doc.CreateElement("CompanyName");
            Name.InnerText = com.CompanyName; 
            xcom = doc.CreateComment("Name of company");
            Name.AppendChild(xcom);

            XmlElement Password = doc.CreateElement("Password");
            Password.InnerText = com.Password;
            xcom = doc.CreateComment("Password");
            Password.AppendChild(xcom);

            XmlElement AvgMark = doc.CreateElement("AverageMarkForStudent");
            AvgMark.InnerText = com.AvgMark.ToString();
            xcom = doc.CreateComment("Average mark");
            AvgMark.AppendChild(xcom);

            XmlElement WorkExp = doc.CreateElement("WorkExp");
            WorkExp.InnerText = com.WorkExperience.ToString();
            xcom = doc.CreateComment("WorkExp");
            WorkExp.AppendChild(xcom);


            elem.AppendChild(Name);
            elem.AppendChild(Password);
            elem.AppendChild(AvgMark);
            elem.AppendChild(WorkExp);
            doc.DocumentElement.AppendChild(elem);
            doc.Save(path);
        }


        private XmlDocument getDocument()
        {
            XmlDocument xd = new XmlDocument();

            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                xd.Load(path);
            }
            else
            {
                XmlElement xl = xd.CreateElement("Companies");
                xd.AppendChild(xl);
                xd.Save(path);
            }
            return xd;
        }


        public Students FindCandidate(ref List<Students> list)
        {
           
            Students stud = new Students();
            Company company = GetRequirements(comp);
            foreach (Students item in list)
            {
                if (company.AvgMark >= item.Resume.AvgMark && company.WorkExperience == item.Resume.WorkExpirience)
                {
                    Console.WriteLine($"Name {company.CompanyName}\n Password {company.Password}\n " +
                   $"Requirment average mark {company.AvgMark}\n Experience {company.WorkExperience}\n ");
                    stud = item;
                    Console.WriteLine($"Name {stud.FullName}\n ID {stud.ID}\n Faculty {stud.Faculty}\n Course {stud.Course}\n Regist date {stud.RegDate}\n\n Resume:\n" +
                    $" Name:  {stud.Resume.FullName}\n Faculty {stud.Resume.Faculty}\n " +
                    $"Course: {stud.Resume.Course}\n Average mark: {stud.Resume.AvgMark}\n" +
                    $"Work exp: {stud.Resume.WorkExpirience}\n ");
                }
                    
            }
            
            return stud;

        }




        public Company GetRequirements (List<Company> comp)
        {
            Company find = comp.ElementAt(r.Next(0, 7));
           

            return find;
        }


        public void PrintCompany()
        {
            foreach (Company item in comp)
            {
                Console.WriteLine($"Name {item.CompanyName}\n Password {item.Password}\n " +
                    $"Requirment average mark {item.AvgMark}\n Experience {item.WorkExperience}\n");
            }

        }

    }
}
