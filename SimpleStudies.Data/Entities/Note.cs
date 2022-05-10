using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies.Data.Entities
{
    public class Note : IEntity
    {
        public decimal EndNote { get; set; }
        public int Id { get; set; }
        public Kurs Kurs { get; set; }
        public int KursId { get; set; }
        public string Typ { get; set; }
    }
}
