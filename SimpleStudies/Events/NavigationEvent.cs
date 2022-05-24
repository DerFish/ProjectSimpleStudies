using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleStudies.Models.Enums;

namespace SimpleStudies.Events
{
    public class NavigationEvent : EventArgs
    {
        public NavigationEvent(NavView view)
        {
            NavToView = view;
        }

        public NavView NavToView { get; set; }
    }
}
