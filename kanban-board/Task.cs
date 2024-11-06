using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanban_board
{
    internal class Task:Item
    {
        private DateTime dueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        private DateTime completionDate
        {
            get { return completionDate; }
            set { completionDate = value; }
        }
        public Task(string n, string d, DateTime dd = new DateTime()) : base(n,d)
        {
            this.dueDate = dd;
        }
    }
}
