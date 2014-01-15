using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentConsoleDemo {
    public class Program {
        public static void Main(string[] args) {
            FluentConsole
                .White.Background.Black.Line("Black");
            
            FluentConsole
                .Cyan.Line("Cyan")
                .DarkBlue.Line("DarkBlue")
                .DarkCyan.Line("DarkCyan")
                .DarkGray.Line("DarkGray")
                .DarkGreen.Line("DarkGreen")
                .DarkMagenta.Line("DarkMagenta")
                .DarkRed.Line("DarkRed")
                .DarkYellow.Line("DarkYellow")
                .Gray.Line("Gray")
                .Green.Line("Green")
                .Magenta.Line("Magenta")
                .Red.Line("Red")
                .White.Line("White")
                .Yellow.Line("Yellow");

            Console.ReadKey();
        }
    }
}
