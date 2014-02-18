

using System;
using JetBrains.Annotations;

partial class FluentConsole {
    partial interface IMainSyntax {
         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Black" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Black { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.DarkBlue" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax DarkBlue { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.DarkGreen" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax DarkGreen { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.DarkCyan" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax DarkCyan { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.DarkRed" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax DarkRed { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.DarkMagenta" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax DarkMagenta { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.DarkYellow" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax DarkYellow { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Gray" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Gray { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.DarkGray" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax DarkGray { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Blue" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Blue { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Green" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Green { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Cyan" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Cyan { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Red" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Red { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Magenta" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Magenta { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.Yellow" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax Yellow { get; }

         /// <summary>
         /// Sets foreground color to <see cref="ConsoleColor.White" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
         /// Only applies to calls made on instance it returns.
         /// </summary>
         [NotNull]
         IAfterColorSyntax White { get; }

    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Black" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Black {
        get { return instance.Black; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.DarkBlue" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax DarkBlue {
        get { return instance.DarkBlue; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.DarkGreen" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax DarkGreen {
        get { return instance.DarkGreen; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.DarkCyan" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax DarkCyan {
        get { return instance.DarkCyan; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.DarkRed" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax DarkRed {
        get { return instance.DarkRed; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.DarkMagenta" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax DarkMagenta {
        get { return instance.DarkMagenta; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.DarkYellow" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax DarkYellow {
        get { return instance.DarkYellow; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Gray" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Gray {
        get { return instance.Gray; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.DarkGray" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax DarkGray {
        get { return instance.DarkGray; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Blue" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Blue {
        get { return instance.Blue; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Green" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Green {
        get { return instance.Green; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Cyan" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Cyan {
        get { return instance.Cyan; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Red" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Red {
        get { return instance.Red; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Magenta" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Magenta {
        get { return instance.Magenta; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.Yellow" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Yellow {
        get { return instance.Yellow; }
    }

    /// <summary>
    /// Sets foreground color to <see cref="ConsoleColor.White" /> for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
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