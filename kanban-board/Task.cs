using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanban_board
{
    public class Task:Item
    {
        //an Item that denotes a specific task that can or cannot have a date it should be completed by. 
        private DateTime dueDate;
        private DateTime completionDate;
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        private DateTime CompletionDate
        {
            get { return completionDate; }
            set { completionDate = value; }
        }
        public Task(string n, string d, int c, DateTime dd = new DateTime()) : base(n,d,c)
        {
            this.dueDate = dd;
        }

        public override void WriteBinary(BinaryWriter bw)
        {
            bw.Write("TaskItem");
            bw.Write(name);
            bw.Write(description);
            bw.Write(category);
            bw.Write(dueDate.ToBinary());
            bw.Write(completionDate.ToBinary());
        }
        public override void ReadBinary(BinaryReader br)
        {
            this.name = br.ReadString();
            this.description = br.ReadString();
            this.category = br.ReadInt16();
            this.dueDate = DateTime.FromBinary(br.ReadInt64());
            this.completionDate = DateTime.FromBinary(br.ReadInt64());
        }
    }
}
