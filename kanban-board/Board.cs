namespace kanban_board
{
	public class Board
	{
		private string? name;
		private List<Item> items = new List<Item>();
		private List<string> categories = new() { "To Do", "Doing", "Done"};

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public List<Item> GetItems()
		{
			return items;
		}
		public List<string> GetCategories() 
		{
			return categories;
		}
		public void AddTask(string nameInput, string descriptionInput, int categoryInput, DateTime dueDateInput = new DateTime())
		{
			Task taskToAdd = new Task();

			taskToAdd.Name = nameInput;
			taskToAdd.Description = descriptionInput;
			taskToAdd.Category = categoryInput;
			if(dueDateInput == new DateTime())
			{
				taskToAdd.DueDate = dueDateInput;
			}

			items.Add(taskToAdd);
        }
		public void AddEvent(string nameInput, string descriptionInput, int categoryInput, DateTime startDateInput, DateTime endDateInput) 
		{
			Event eventToAdd = new Event();

			eventToAdd.Name = nameInput;
			eventToAdd.Description = descriptionInput;
			eventToAdd.Category = categoryInput;
			eventToAdd.StartDate = startDateInput;
			eventToAdd.EndDate = endDateInput;

			items.Add(eventToAdd);
		}
		public void WriteBinary(BinaryWriter bw)
		{
			bw.Write("Board");
			bw.Write(name);
			bw.Write(items.Count); //integer to note how many items there are
			foreach(Item item in items)
			{
				item.WriteBinary(bw);
			}
			bw.Write(categories.Count);
			foreach(string category in categories)
			{
				bw.Write(category);
			}
		}
		public void ReadBinary(BinaryReader br)
		{
			name = br.ReadString();

			//reading Items List from binary
			for (int i = 0; i < br.ReadInt32(); i++)
			{
				Item itemToAdd = new Task(); // DEFAULT TO TASK BECAUSE A VALUE IS NEEDED
				if((br.ReadString() == "EventItem")){
					itemToAdd = new Event();
					itemToAdd.ReadBinary(br);

				}
				else if(br.ReadString() == "TaskItem")
				{
					itemToAdd = new Task();
					itemToAdd.ReadBinary(br);
				}
                this.items.Add(itemToAdd);
			}

			categories = new List<string>();
			//reading category list from binary
			for(int i = 0; i < br.ReadInt32(); i++)
			{
				categories.Add(br.ReadString());
			}
		}
	}
}

