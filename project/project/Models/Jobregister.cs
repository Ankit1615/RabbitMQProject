﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace project.Models
{
    public partial class Jobregister
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Mobile { get; set; }
        public bool? Workstatus { get; set; }
        public DateTime? Dob { get; set; }
        public string Resumes { get; set; }
    }
}