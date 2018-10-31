using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EnumsAndStructs
{
    public class Student
    {
        public static int Id { get; set; }
        public string FullName { get; set; }
        public string Group { get; set; }
        public int AverageMark { get; set; }
        public int IncomePerPerson { get; set; }
        public Gender Gender { get; set; }
        public FormOfStudy FormOfStudy { get; set; }

        static Student()
        {
            Id = 0;
        }

        public Student(string fullName, string group, int averageMark, int incomePerPerson, Gender gender, FormOfStudy formOfStudy)
        {
            Id++;
            this.FullName = fullName;
            this.Group = group;
            this.AverageMark = averageMark;
            this.IncomePerPerson = incomePerPerson;
            this.Gender = gender;
            this.FormOfStudy = formOfStudy;
        }
    }
}
