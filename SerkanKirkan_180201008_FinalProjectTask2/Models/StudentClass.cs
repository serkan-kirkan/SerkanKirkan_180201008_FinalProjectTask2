using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerkanKirkan_180201008_FinalProjectTask2.Models
{
    public class StudentClass
    {
        [PrimaryKey,AutoIncrement]
        public int Student_ID { get; set; }
        public string Student_NameSurname { get; set; }
        public string Department_Name { get; set; }

    }
}
