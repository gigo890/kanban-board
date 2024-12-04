using System;
namespace kanban_board
{
	public abstract class Item
	{
		//Master class for every type of item included in a board. 
		protected string name;
		protected string description;
		protected int category;
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
		public int Category
		{
			get { return category; }
			set { category = value; }
		}

		//Constructor removed since I need to have an empty Item when reading from binary

		//public Item(string n, string d, int c)
		//{
		//	//Constructor for items

		//	this.name = n;
		//	this.description = d;
		//	this.category = c;
		//}

		public abstract void WriteBinary(BinaryWriter bw);
		public abstract void ReadBinary(BinaryReader br);
	}
}