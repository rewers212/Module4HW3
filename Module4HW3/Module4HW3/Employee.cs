﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? HiredDate { get; set; }
        public DateTime? DateOdBirth { get; set; }
        public int OfficeId { get; set; }
        public int TitleId { get; set; }
    }
}
