using Microsoft.AspNetCore.Http;
using System;
using System.Data.Entity;
using System.Linq;

namespace adbms_group_project.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        
    }

}