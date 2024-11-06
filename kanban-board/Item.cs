using System;

public class Item
{
	protected int id { 
		get { return id; }
		set { id = value; }
	}
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


	public Item(string n, string d)
	{
		//Constructor for tasks
		//optional parameter for due date

		name = n;
		description = d;
	}

	// -- Gets and Sets for all attributes. --
	public int Id
	{
		get { return id; }
	}
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
}
