using Microsoft.EntityFrameworkCore;
using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Services
{
    public class StudentInfoContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public StudentInfoContext()
        {
            SQLitePCL.Batteries_V2.Init();

            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "studentinfo.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }
    }
}
