using System;
namespace kanban_board
{
	public class Item
	{
		protected string name
		{
			get { return name; }
			set { name = value; }
		}
		protected string description
		{
			get { return description; }
			set { description = value; }
		}
		protected string category
		{
			get { return category; }
			set { category = value; }
		}


		public Item(string n, string d, string c)
		{
			//Constructor for tasks

			this.name = n;
			this.description = d;
			this.category = c;
		}
	}
}