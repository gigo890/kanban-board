namespace kanban_board
{
	public class Board
	{
		private List<Item> items;
		private List<string> categories;
		public Board()
		{
			this.items = new List<Item>();
			this.categories = new List<string>() { "To Do","Doing","Done"};
		}
		public void AddTask(string nameInput, string descriptionInput, int categoryInput, DateTime dueDateInput = new DateTime())
		{
			if(dueDateInput == new DateTime())
			{
				items.Add(new Task(nameInput, descriptionInput, categoryInput));
			}
            else
            {
                items.Add(new Task(nameInput, descriptionInput, categoryInput));
            }
        }
		public void MoveCategoryUp()
		{
			//Moves current task's category up
		}
		public void MoveCategoryDown()
		{
			//Moves current task's category down
		}
		public void WriteBinary(BinaryWriter bw)
		{
			bw.Write("Board");
			bw.Write(items.Count);
			foreach(Item item in items)
			{
				item.WriteBinary(bw);
			}
			bw.Write(categories.Count);
			foreach(string category in categories)
			{
				bw.Write(category);
			}
			//options for writing a list to binary file: 
			//- iterate over the list and use the WriteBinary function for each item
			//- 
		}
		public void ReadBinary(BinaryReader br)
		{
			for(int i = 0; i < br.ReadInt32(); i++)
			{
				this.items.Add()
			}
		}
	}
}

