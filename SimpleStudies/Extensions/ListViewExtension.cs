using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStudies.Extensions
{
    public static class ListViewExtension
    {
        public static void AutoSizeColumnList(this ListView listView)
        {
            //Prevents flickering
            listView.BeginUpdate();
            for (int i = 0; i <= listView.Columns.Count - 1; i++)
            {
                listView.Columns[i].Width = -2;
            }

            listView.EndUpdate();
        }
    }
}
