using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerkanKirkan_180201008_FinalProjectTask2.Models
{
    public class CategoryClass
    {
            [PrimaryKey, AutoIncrement]
            public int Category_ID { get; set; }
            public string Category_Name { get; set; }
        
    }
}
