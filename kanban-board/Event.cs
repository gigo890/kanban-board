using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanban_board
{
    internal class Event
    {
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
        public Event(DateTime sd, DateTime ed)
        {
            this.startDate = sd;
            this.endDate = ed;
        }
    }
}
