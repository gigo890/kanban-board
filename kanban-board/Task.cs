using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanban_board
{
    public class Task:Item
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
        public Task(string n, string d, string c, DateTime dd = new DateTime()) : base(n,d,c)
        {
            this.dueDate = dd;
        }
    }
}
