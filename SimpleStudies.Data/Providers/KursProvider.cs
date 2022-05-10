using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
