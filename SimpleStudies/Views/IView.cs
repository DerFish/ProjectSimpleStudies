using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies.Views
{
    internal interface IView
    {
        int Semester { get; set; }

        void ResetView();
    }
}
