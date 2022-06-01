using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleStudies.Data.Entities;

namespace SimpleStudies.Data.Providers
{
    public class HausaufgabeProvider : ProviderBase<Hausaufgabe>
    {
        private static HausaufgabeProvider instance;

        private HausaufgabeProvider()
        {
        }

        /// <summary>
        /// Gets the singleton instance for this provider
        /// </summary>
        public static HausaufgabeProvider Instance => instance ?? (instance = new HausaufgabeProvider());

        public void Edit(Hausaufgabe selectedElement)
        {
            throw new NotImplementedException();
        }

        public List<Hausaufgabe> GetAll()
        {
            using (var context = new SimpleStudiesDbContext())
            {
                return context.Hausaufgabe
                    .Include(i => i.Kurs)
                    .ToList();
            }
        }
    }
}
