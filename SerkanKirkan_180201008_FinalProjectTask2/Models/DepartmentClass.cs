﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerkanKirkan_180201008_FinalProjectTask2.Models
{
    public class DepartmentClass
    {
        [AutoIncrement,PrimaryKey]
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
    }
}
