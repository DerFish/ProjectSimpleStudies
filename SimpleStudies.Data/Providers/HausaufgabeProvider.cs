using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
