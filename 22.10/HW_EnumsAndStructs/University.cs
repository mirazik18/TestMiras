using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EnumsAndStructs
{
    public class University
    {
        public static int Id { get; set; }
        public List<Student> StudentList { get; set; }
        public int MinimalSalary { get; set; }

        public University(int minimalSalary)
        {
            Id = 0;
            StudentList = new List<Student>();
            MinimalSalary = minimalSalary;
        }

        public void AddStudent(Student student)
        {
            this.StudentList.Add(student);
        }

        public List<Student> Obshaga()
        {
            List<Student> result = new List<Student>();
            List<Student> tempList = new List<Student>();



            for (int i = 0; i < this.StudentList.Count; i++)
            {
                tempList.Add(StudentList[i]);
                if (tempList[i].IncomePerPerson < (2 * MinimalSalary))
                {
                    result.Add(tempList[i]);
                    tempList.Remove(tempList[i]);
                }
            }

            var sortedUsers = from u in tempList
                              orderby u.AverageMark descending
                              select u;

            foreach(Student student in sortedUsers)
                result.Add(student);

            return result;
        }
    }
}
