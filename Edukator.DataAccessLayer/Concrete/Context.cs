﻿using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-51V7O1A;initial catalog=DbEdukator;integrated security=true;");
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ContactInfo> ContactInfos { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Map> Maps { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}