using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanban_board
{
    internal class Event:Item
    {
        //--ATTRIBUTES--//   

        private DateTime startDate;//when the event starts
        private DateTime endDate; //when the event ends

        //public gets and sets for each attribute
        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }
        public DateTime EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

        //Constructor for Event, taking base values from Item
        //public Event(string n, string d, string c, DateTime sd, DateTime ed): base(n,d,c)
        //{
        //    this.startDate = sd;
        //    this.endDate = ed;
        //}

        //--METHODS-//
        public override void WriteBinary(BinaryWriter bw)
        {
            bw.Write("EventItem");
            bw.Write(name);
            bw.Write(description);
            bw.Write(category);
            bw.Write(startDate.ToBinary());
            bw.Write(endDate.ToBinary());
        }
        public override void ReadBinary(BinaryReader br)
        {
            throw new NotImplementedException();
        }
    }
}
