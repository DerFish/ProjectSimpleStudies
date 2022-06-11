using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleStudies.Data.Entities;

namespace SimpleStudies.Data.Providers
{
    public class DozentProvider : ProviderBase<Dozent>
    {
        private static DozentProvider instance;

        private DozentProvider()
        {
        }

        /// <summary>
        /// Gets the singleton instance for this provider
        /// </summary>
        public static DozentProvider Instance => instance ?? (instance = new DozentProvider());

        public void Delete(Dozent selectedElement)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                foreach (var course in context.Kurs.Where(w => w.DozentId == selectedElement.Id))
                {
                    context.Hausaufgabe.RemoveRange(context.Hausaufgabe.Where(w => w.KursId == course.Id));
                    context.Note.RemoveRange(context.Note.Where(w => w.KursId == course.Id));
                    context.Lernplan.RemoveRange(context.Lernplan.Where(w => w.KursId == course.Id));

                    context.Kurs.Remove(context.Kurs.FirstOrDefault(f => f.Id == course.Id));
                }

                context.Dozent.Remove(context.Dozent.FirstOrDefault(f => f.Id == selectedElement.Id));

                context.SaveChanges();
            }
        }

        public void Edit(Dozent element)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                context.Dozent.Attach(element);
                context.Entry(element).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Dozent> GetAll()
        {
            using (var context = new SimpleStudiesDbContext())
            {
                return context.Dozent.ToList();
            }
        }
    }
}
