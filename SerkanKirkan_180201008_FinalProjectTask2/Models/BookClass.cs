using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerkanKirkan_180201008_FinalProjectTask2.Models
{
    public class BookClass
    {
        [PrimaryKey,AutoIncrement]
        public int Book_ID { get; set; }
        public string Book_Name { get; set; }
        public string Book_Author{ get; set; }
        public string Book_Page { get; set; }

    }

}
