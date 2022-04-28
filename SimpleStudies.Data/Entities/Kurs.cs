using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies.Data.Entities
{
    public class Kurs
    {
        public Dozent Dozent { get; set; }
        public int DozentId { get; set; }
        public int ECTS { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
    }
}
