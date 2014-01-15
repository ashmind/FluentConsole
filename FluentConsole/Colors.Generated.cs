

using System;
using FluentConsoleInternal;

partial class FluentConsole {
    partial interface IMainSyntax {
         [NotNull] IAfterColorSyntax Black { get; }
         [NotNull] IAfterColorSyntax DarkBlue { get; }
         [NotNull] IAfterColorSyntax DarkGreen { get; }
         [NotNull] IAfterColorSyntax DarkCyan { get; }
         [NotNull] IAfterColorSyntax DarkRed { get; }
         [NotNull] IAfterColorSyntax DarkMagenta { get; }
         [NotNull] IAfterColorSyntax DarkYellow { get; }
         [NotNull] IAfterColorSyntax Gray { get; }
         [NotNull] IAfterColorSyntax DarkGray { get; }
         [NotNull] IAfterColorSyntax Blue { get; }
         [NotNull] IAfterColorSyntax Green { get; }
         [NotNull] IAfterColorSyntax Cyan { get; }
         [NotNull] IAfterColorSyntax Red { get; }
         [NotNull] IAfterColorSyntax Magenta { get; }
         [NotNull] IAfterColorSyntax Yellow { get; }
         [NotNull] IAfterColorSyntax White { get; }
    }

    public static IAfterColorSyntax Black {
        get { return instance.Black; }
    }

    public static IAfterColorSyntax DarkBlue {
        get { return instance.DarkBlue; }
    }

    public static IAfterColorSyntax DarkGreen {
        get { return instance.DarkGreen; }
    }

    public static IAfterColorSyntax DarkCyan {
        get { return instance.DarkCyan; }
    }

    public static IAfterColorSyntax DarkRed {
        get { return instance.DarkRed; }
    }

    public static IAfterColorSyntax DarkMagenta {
        get { return instance.DarkMagenta; }
    }

    public static IAfterColorSyntax DarkYellow {
        get { return instance.DarkYellow; }
    }

    public static IAfterColorSyntax Gray {
        get { return instance.Gray; }
    }

    public static IAfterColorSyntax DarkGray {
        get { return instance.DarkGray; }
    }

    public static IAfterColorSyntax Blue {
        get { return instance.Blue; }
    }

    public static IAfterColorSyntax Green {
        get { return instance.Green; }
    }

    public static IAfterColorSyntax Cyan {
        get { return instance.Cyan; }
    }

    public static IAfterColorSyntax Red {
        get { return instance.Red; }
    }

    public static IAfterColorSyntax Magenta {
        get { return instance.Magenta; }
    }

    public static IAfterColorSyntax Yellow {
        get { return instance.Yellow; }
    }

    public static IAfterColorSyntax White {
        get { return instance.White; }
    }

}

namespace FluentConsoleInternal {
    partial class MainSyntax {
        public FluentConsole.IAfterColorSyntax Black {
            get { return Color(ConsoleColor.Black); }
        }

        public FluentConsole.IAfterColorSyntax DarkBlue {
            get { return Color(ConsoleColor.DarkBlue); }
        }

        public FluentConsole.IAfterColorSyntax DarkGreen {
            get { return Color(ConsoleColor.DarkGreen); }
        }

        public FluentConsole.IAfterColorSyntax DarkCyan {
            get { return Color(ConsoleColor.DarkCyan); }
        }

        public FluentConsole.IAfterColorSyntax DarkRed {
            get { return Color(ConsoleColor.DarkRed); }
        }

        public FluentConsole.IAfterColorSyntax DarkMagenta {
            get { return Color(ConsoleColor.DarkMagenta); }
        }

        public FluentConsole.IAfterColorSyntax DarkYellow {
            get { return Color(ConsoleColor.DarkYellow); }
        }

        public FluentConsole.IAfterColorSyntax Gray {
            get { return Color(ConsoleColor.Gray); }
        }

        public FluentConsole.IAfterColorSyntax DarkGray {
            get { return Color(ConsoleColor.DarkGray); }
        }

        public FluentConsole.IAfterColorSyntax Blue {
            get { return Color(ConsoleColor.Blue); }
        }

        public FluentConsole.IAfterColorSyntax Green {
            get { return Color(ConsoleColor.Green); }
        }

        public FluentConsole.IAfterColorSyntax Cyan {
            get { return Color(ConsoleColor.Cyan); }
        }

        public FluentConsole.IAfterColorSyntax Red {
            get { return Color(ConsoleColor.Red); }
        }

        public FluentConsole.IAfterColorSyntax Magenta {
            get { return Color(ConsoleColor.Magenta); }
        }

        public FluentConsole.IAfterColorSyntax Yellow {
            get { return Color(ConsoleColor.Yellow); }
        }

        public FluentConsole.IAfterColorSyntax White {
            get { return Color(ConsoleColor.White); }
        }

    }
}