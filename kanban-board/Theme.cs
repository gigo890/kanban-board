using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanban_board
{
    internal class Theme
    {
        private Dictionary<string, string[]> themes = new Dictionary<string, string[]>()
        {
            ["default"] = new[] { "\u001b[0m" /*white*/, "\u001b[0m" /*white*/, "\u001b[32m" /*red*/ }
        };
        private string currentTheme = "default";

        public string GetColor(int input)
        {
            return themes[currentTheme][input];
        }
    }
}
