﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ASPNETCoreHW1.Models
{
    [Index(nameof(InstructorId), Name = "IX_InstructorID")]
    public partial class Department
    {
        public Department()
        {
            Course = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? InstructorId { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual Person Instructor { get; set; }
        public virtual ICollection<Course> Course { get; set; }
    }
}