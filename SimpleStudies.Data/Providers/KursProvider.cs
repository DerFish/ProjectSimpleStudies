using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleStudies.Data.Entities;

namespace SimpleStudies.Data.Providers
{
    public class KursProvider : ProviderBase<Kurs>
    {
        private static KursProvider instance;

        private KursProvider()
        {
        }

        /// <summary>
        /// Gets the singleton instance for this provider
        /// </summary>
        public static KursProvider Instance => instance ?? (instance = new KursProvider());

        public void Edit(Kurs element)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                context.Kurs.Attach(element);
                context.Entry(element).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Kurs> GetAll(int semester)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                return context.Kurs
                    .Where(w => semester == 0 || w.Semester == semester)
                    .Include(i => i.Dozent)
                    .ToList();
            }
        }
    }
}
