using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kanban_board
{
    internal class Theme
    {
        protected Dictionary<string, string[]> themes = new Dictionary<string, string[]>()
        {
            ["default"] = new[] { "white", "white", "white" }
        };
        protected string currentTheme = "default";

        public string GetColor(int input)
        {
            return themes[currentTheme][input];
        }
    }
}
