using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
