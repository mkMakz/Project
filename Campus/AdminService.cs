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
    public class AdminService
    {
        private Random r = new Random();
        private string path = @"Students.xml";
        public  List<Students> st = new List<Students>();


        public void GenerStudents()
        {
            Generator g = new Generator();
            for (int i = 0; i < 10; i++)
            {
                Students students = new Students();
                students.FullName = g.GenerateDefault(Gender.man);
                students.ID = i + 1; 
                students.Faculty = (Faculty)r.Next(1, 5);
                students.Course = r.Next(1, 6);
                students.RegDate = DateTime.Now.AddMonths(-r.Next(1, 40));
                students.Resume.FullName = students.FullName;
                students.Resume.Faculty = students.Faculty;
                students.Resume.Course = students.Course;
                students.Resume.AvgMark = r.Next(75, 97);
                students.Resume.WorkExpirience = r.Next(0, 3);
                st.Add(students);
                addStudentToXml(students);
            }
        }

        public void CreateStudent()
        {
            Students students = new Students();
            Console.WriteLine("Enter name of student:");
            students.FullName = Console.ReadLine();
            Console.WriteLine("Enter an ID");
            students.ID =Int32.Parse(Console.ReadLine()); 
            students.Faculty = (Faculty)r.Next(1, 5);
            students.Course = r.Next(1, 6);
            students.RegDate = DateTime.Now.AddMonths(-r.Next(1, 40));
            students.Resume.FullName = students.FullName;
            students.Resume.Faculty = students.Faculty;
            students.Resume.Course = students.Course;
            students.Resume.AvgMark = r.Next(75, 97);
            students.Resume.WorkExpirience = r.Next(0, 3);
            st.Add(students);
            addStudentToXml(students);

        }


        private void addStudentToXml(Students students)
        {
            XmlDocument doc = getDocument();
            XmlComment xcom;
            XmlElement elem = doc.CreateElement("Student");

            XmlElement Name = doc.CreateElement("Name");
            Name.InnerText = students.FullName;
            xcom = doc.CreateComment("Name of student");
            Name.AppendChild(xcom);

            XmlElement ID = doc.CreateElement("ID");
            ID.InnerText = students.ID.ToString();
            xcom = doc.CreateComment("Unique ID");
            ID.AppendChild(xcom);

            XmlElement Faculty = doc.CreateElement("Faculty");
            Faculty.InnerText = students.Faculty.ToString();
            xcom = doc.CreateComment("Faculty");
            Faculty.AppendChild(xcom);

            XmlElement Course = doc.CreateElement("Course");
            Course.InnerText = students.Course.ToString();
            xcom = doc.CreateComment("Students course");
            Course.AppendChild(xcom);

            XmlElement DateReg = doc.CreateElement("DateReg");
            DateReg.InnerText = students.RegDate.ToString();
            xcom = doc.CreateComment("Registration date");
            DateReg.AppendChild(xcom);

            XmlElement elem2 = doc.CreateElement("Resume");

            XmlElement FullName = doc.CreateElement("Name");
            FullName.InnerText = students.Resume.FullName;
            xcom = doc.CreateComment("Student name");
            FullName.AppendChild(xcom);

            XmlElement Faculty2 = doc.CreateElement("Faculty");
            Faculty2.InnerText = students.Resume.Faculty.ToString();
            xcom = doc.CreateComment("Faculty");
            Faculty2.AppendChild(xcom);

            XmlElement Course2 = doc.CreateElement("Course");
            Course2.InnerText = students.Resume.Course.ToString();
            xcom = doc.CreateComment("Students course");
            Course2.AppendChild(xcom);

            XmlElement AvgMark = doc.CreateElement("Mark");
            AvgMark.InnerText = students.Resume.AvgMark.ToString();
            xcom = doc.CreateComment("Average mark");
            AvgMark.AppendChild(xcom);

            XmlElement WorkExpirience = doc.CreateElement("WorkExpirience");
            WorkExpirience.InnerText = students.Resume.WorkExpirience.ToString();
            xcom = doc.CreateComment("Average mark");
            WorkExpirience.AppendChild(xcom);


        
            elem.AppendChild(Name);
            elem.AppendChild(ID);
            elem.AppendChild(Faculty);
            elem.AppendChild(Course);
            elem.AppendChild(DateReg);
            elem2.AppendChild(FullName);
            elem2.AppendChild(Faculty2);
            elem2.AppendChild(Course2);
            elem2.AppendChild(AvgMark);
            elem2.AppendChild(WorkExpirience);
            elem.AppendChild(elem2);
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
                XmlElement xl = xd.CreateElement("Students");
                xd.AppendChild(xl);
                xd.Save(path);
            }
            return xd;
        }


        public void PrintStudent()
        {
            foreach (Students item in st)
            {
                Console.WriteLine($"Name {item.FullName}\n ID {item.ID}\n Faculty {item.Faculty}\n Course {item.Course}\n Regist date {item.RegDate}\n\n Resume:\n" +
                        $" Name:  {item.Resume.FullName}\n Faculty {item.Resume.Faculty}\n " +
                        $"Course: {item.Resume.Course}\n Average mark: {item.Resume.AvgMark}\n" +
                        $"Work exp: {item.Resume.WorkExpirience}\n ");

            }
        }

    }
}
