using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;

namespace CourseSystem_DAL
{
    public class Human
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone {  get; set; }
        public Human(Guid id ,string? firstName, string? lastName, string? phone)
        {
            Id= id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
    }
}
