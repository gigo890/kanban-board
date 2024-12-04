using System.Drawing;

namespace kanban_board
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Theme theme = new Theme();
            List<Board> boards = new List<Board>();
            Board currentBoard;

            Console.WriteLine("Welcome to this Kanban Board program.");
            Console.WriteLine("Please select an option:");

            //Generating the Main Menu
            string[] options;
            if (File.Exists("Boards.dat")) //the "Open Board" option only shows when a board already exists 
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
           
        public void ReadBoardFromBinaryFile()
        {
            Board board = new Board();

            FileStream fsr = new FileStream("Boards.dat", FileMode.Open);
            BinaryReader br = new BinaryReader(fsr);

            for(int i = 0; i < br.ReadInt32(); i++)
            {
                board.ReadBinary(br);
            }
        }
        public void WriteBoardToBinaryFile(List<Board> boardsToWrite) 
        {
            FileStream fsr = new FileStream("Boards.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fsr);

            foreach(Board board in boardsToWrite)
            {
                board.WriteBinary(bw);
            }
        }
    }
    
}