using System.Drawing;

namespace kanban_board
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Theme theme = new Theme();

            Console.WriteLine("Welcome to this Kanban Board program.");
            Console.WriteLine("Please select an option:");

            //ConsoleKeyInfo key;
            //int optionMin = 2;
            //int option = 2;
            //bool isSelected = false;
            //(int left, int top) = Console.GetCursorPosition();
            //Console.CursorVisible = false;
            //string colourOne = theme.GetColor(0);
            //string colourTwo = theme.GetColor(1);
            //string selectedColour = theme.GetColor(2);

            //while(!isSelected)
            //{
            //    Console.SetCursorPosition(left, top);
            //    if (File.Exists("boards.json"))
            //    {
            //        Console.WriteLine($"{(option == 1 ? selectedColour : "")}Open Board{colourOne}[0m");
            //        optionMin = 1;
            //        option = 1;
            //    }
            //    Console.WriteLine($"{(option == 2 ? selectedColour : ""/*THEME FUNCTION HERE*/)}Option 1{colourOne}");
            //    Console.WriteLine($"{(option == 3 ? selectedColour : ""/*THEME FUNCTION HERE*/)}Option 2{colourOne}");
            //    Console.WriteLine($"{(option == 4 ? selectedColour : ""/*THEME FUNCTION HERE*/)}Option 3{colourOne}");

            //    key = Console.ReadKey(true);
            //    switch (key.Key)
            //    {
            //        case ConsoleKey.DownArrow:
            //            option = (option == 4 ? optionMin : option + 1);
            //            break;

            //        case ConsoleKey.UpArrow:
            //            option = (option == optionMin ? 4 : option - 1); 
            //            break;

            //        case ConsoleKey.Enter:
            //            isSelected = true;
            //            break;
            //    }
            //}

            //Generating the Main Menu
            string[] options;
            if (File.Exists("boards.json")) //the "Open Board" option only shows when a board already exists 
                    {
                        options = new string[] { "Open Board", "Create New Board", "Select Theme", "Exit Program" };
                    }
            else
            {
                options = new string[] { "Create New Board", "Select Theme", "Exit program" };
            }
            string option = SelectMenu(options,theme);

            Console.Clear();
            switch (option) //Main menu options
            {
                case "Open Board":

                    break;

                case "Create New Board":
                    Console.WriteLine($"{theme.GetColor(0)}//--Board Create--//");
                    break;

                case "Select Theme":
                    break;

                case "Exit Program":
                    break;
            }

        }
        public static string SelectMenu(string[] options, Theme theme)
        {
            ConsoleKeyInfo key;         //key press status
            int selected = 0;           //points to selected option
            bool isComplete = false;    //checks if the user has selected an option

            (int left, int top) = Console.GetCursorPosition(); //gets starting cursor position
            Console.CursorVisible = false; //makes the cursor invisible

            //Gets colours for theme
            string textColour = theme.GetColor(1);
            string selectedColour = theme.GetColor(2);

            while(!isComplete){

                Console.SetCursorPosition(left, top);

                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"{(selected == i ? selectedColour : "")}{options[i]}{textColour}");
                }
                    
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow: //moves down one option, or wraps to the top
                        selected = (selected == options.Length - 1 ? 0 : selected + 1);
                        break;

                    case ConsoleKey.UpArrow: //moves up one option or wraps to the bottom
                        selected = (selected == 0 ? options.Length - 1 : selected - 1);
                        break;
                        
                    case ConsoleKey.Enter: //selects the currently selected option
                        isComplete = true;
                        break;
                }
            }
            return options[selected]; //outputs the selected option
        }
            //options:
            //open board (if there are boards)
            //create new board
            //exit program


            //string[] options = { "Open Board", "Create New Board", "select theme" "[Exit]" };
            //string[] options;

            //if (File.Exists("boards.json"))
            //{
            //    options = new string[] { "Open Board", "Create New Board", "Select Theme", "[Exit]" };
            //}
            //else
            //{
            //    options = new string[] { "Create New Board", "Select Theme", "[Exit]" };
            //}



        

        //potential class/functions for handling multiple choice
        //public int TraverseMenuUp(string[] options, int current)
        //{
        //    if(current == 0)
        //    {
        //        return options.Length - 1;
        //    }
        //    else
        //    {
        //        return current + 1;
        //    }
        //}

        //public int TraverseMenuDown(string[options], int current)
        //{

        //}
        //public string MainMenu(string[] optionsInput)
        //{
        //    string[] options = optionsInput;
        //    int currentOption = 0;
        //    var keyCommands = new Dictionary<string, Action>();
        //    string key = " ";

        //    keyCommands["Up"] = TraverseMenuUp;
        //    keyCommands["Down"] = TraverseMenuDown;

        //    while ((int)key[0] != 27)
        //    {
        //        key = Console.ReadKey(true).KeyChar.ToString().ToUpper();

        //        if (keyCommands.ContainsKey(key))
        //        {
        //            currentOption = keyCommands[key]();
        //        }
        //    }
        //}
        //public void MainMenuDisplay(string[] options)
        //{

        //}

    }
    
}