using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleStudies.Data.Entities;

namespace SimpleStudies.Data.Providers
{
    public class NoteProvider : ProviderBase<Note>
    {
        private static NoteProvider instance;

        private NoteProvider()
        {
        }

        /// <summary>
        /// Gets the singleton instance for this provider
        /// </summary>
        public static NoteProvider Instance => instance ?? (instance = new NoteProvider());

        public void Edit(Note element)
        {
            using (var context = new SimpleStudiesDbContext())
            {
                context.Note.Attach(element);
                context.Entry(element).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<Note> GetAll()
        {
            using (var context = new SimpleStudiesDbContext())
            {
                return context.Note
                    .Include(i => i.Kurs)
                    .ToList();
            }
        }
    }
}
