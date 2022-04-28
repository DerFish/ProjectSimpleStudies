using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies.Data.Entities
{
    public class Lernplan
    {
        public string Beschreibung { get; set; }
        public DateTime? GeplantAm { get; set; }
        public int Id { get; set; }
        public Kurs Kurs { get; set; }
        public int KursId { get; set; }
        public string Notizen { get; set; }
        public int StatusId { get; set; }
    }
}
