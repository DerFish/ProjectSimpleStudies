using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies.Models
{
    public class BindableListViewItem<T> : ListViewItem
        where T : new()
    {
        public BindableListViewItem(string[] lvItem, T data) : base(lvItem)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
