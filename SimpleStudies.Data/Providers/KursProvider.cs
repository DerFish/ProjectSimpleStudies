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

        public void Delete(Kurs element)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                context.Hausaufgabe.RemoveRange(context.Hausaufgabe.Where(w => w.KursId == element.Id));
                context.Note.RemoveRange(context.Note.Where(w => w.KursId == element.Id));
                context.Lernplan.RemoveRange(context.Lernplan.Where(w => w.KursId == element.Id));

                context.Kurs.Remove(context.Kurs.FirstOrDefault(f => f.Id == element.Id));

                context.SaveChanges();
            }
        }

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
