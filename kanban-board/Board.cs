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
		public void AddTask(string nameInput, string descriptionInput, string categoryInput, DateTime dueDateInput = new DateTime())
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
	}
}

