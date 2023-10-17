using adbms_group_project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace adbms_group_project.AdminData
{

    public class AdminDbContext : DbContext
    {
        public AdminDbContext() : base("DefaultConnection")
        {
        }


        public DbSet<Admin> Admins { get; set; }
    }

}