using System;
namespace kanban_board
{
	public class Item
	{
		//Master class for every type of item included in a board. 
		protected string name;
		protected string description;
		protected string category;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Description
		{
			get { return description; }
			set { description = value; }
		}
		public string Category
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