﻿using cle_spring_2021_courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2021_courses
{
    public class UniversityContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=UniversityDB_102021; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course() { 
                    Id = 1,
                    Name = "A.I.",
                    Description = "A.I. For Humans",
                    InstructorId = 1
                }, 
                new Course() {
                    Id = 2,
                    Name = "C# for Anyone",
                    Description = "Bootcamp for C#",
                    InstructorId = 2
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    Name = "Carlos"
                },
                new Instructor()
                {
                    Id = 2,
                    Name = "Davis"
                }
                );

        }

    }
}
