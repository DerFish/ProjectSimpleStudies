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
