using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanban_board
{
    internal class Event:Item
    {
        //an Item that denotes a period of time where an event takes place
        private DateTime startDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }
        private DateTime endDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }
        public Event(string n, string d, string c, DateTime sd, DateTime ed): base(n,d,c)
        {
            this.startDate = sd;
            this.endDate = ed;
        }
    }
}
