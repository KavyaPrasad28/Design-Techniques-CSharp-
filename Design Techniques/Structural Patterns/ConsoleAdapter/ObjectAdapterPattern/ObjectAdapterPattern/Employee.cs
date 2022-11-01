﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAdapterPattern
{
    /// <summary>
    /// This class represents an employee of the organization
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public override string ToString()
        {
            return $"Id #{Id}  FirstName# {FirstName}  LastName# {LastName}  Department# {Department}";
        }
    }
}
