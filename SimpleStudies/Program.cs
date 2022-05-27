using SimpleStudies.Data.Entities;
using SimpleStudies.Data.Providers;

namespace SimpleStudies
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var db = new SimpleStudiesDbContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                db.Database.EnsureCreated();

                //  db.Dozent.Add(new Dozent { Name = "Test", Email = "Test" });
                // db.Kurs.Add(new Kurs { Name = "Test", DozentId = 1 });
                // db.SaveChanges();
            }

            Application.Run(new Main());
        }
    }
}