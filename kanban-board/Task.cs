using System;

public class Task
{
	protected int id;
	protected string name;
	protected string description;
	protected DateTime dueDate;
	protected DateTime completionDate;


	public Task(string n, string d, DateTime dd = new DateTime() )
	{
		//Constructor for tasks
		//optional parameter for due date

		name = n;
		description = d;
		dueDate = dd;
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
	public DateTime DueDate
	{
		get { return dueDate; }
		set { dueDate = value; }
	}
	public DateTime CompletionDate
	{
		get { return completionDate; }
		set { completionDate = value; }
	}

}
