using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleStudies.Data.Entities
{
    public class SimpleStudiesDbContext : DbContext
    {
        public SimpleStudiesDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "simpleSudies.db");
        }

        public string DbPath { get; }
        public DbSet<Dozent> Dozent { get; set; }
        public DbSet<Hausaufgabe> Hausaufgabe { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<Lernplan> Lernplan { get; set; }
        public DbSet<Note> Note { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
