﻿using System.Collections.Generic;

namespace MVCCORE_CodeFirst.Models
{
    public class Department
    {
        public int Id { get; set; }



        public string Name { get; set; }



        public ICollection<Employee> employees { get; set; }
    }
}