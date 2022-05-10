using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleStudies.Data.Entities;

namespace SimpleStudies.Data.Providers
{
    public class LernplanProvider : ProviderBase<Lernplan>
    {
        private static LernplanProvider instance;

        private LernplanProvider()
        {
        }

        /// <summary>
        /// Gets the singleton instance for this provider
        /// </summary>
        public static LernplanProvider Instance => instance ?? (instance = new LernplanProvider());
    }
}
