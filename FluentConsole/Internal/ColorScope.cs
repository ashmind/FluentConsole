using System;

// ReSharper disable CheckNamespace
namespace FluentConsoleInternal {
// ReSharper enable CheckNamespace
    internal class ColorScope : MainSyntax, FluentConsole.IAfterColorSyntax {
        private readonly ConsoleColor? foreground;
        private readonly ConsoleColor? background;
        private ConsoleColor? savedForeground;
        private ConsoleColor? savedBackground;

        public ColorScope(ConsoleColor? foreground, ConsoleColor? background) {
            this.foreground = foreground;
            this.background = background;
        }

        public FluentConsole.IMainSyntax Background {
            get { return new ColorScope(null, this.foreground); }
        }

        protected override void BeforeText() {
            this.savedBackground = Console.BackgroundColor;
            if (this.foreground != null) {
                this.savedForeground = Console.ForegroundColor;
                Console.ForegroundColor = this.foreground.Value;
            }

            if (this.background != null) {
                this.savedBackground = Console.BackgroundColor;
                Console.BackgroundColor = this.background.Value;
            }
        }

        protected override void AfterText() {
            if (this.savedForeground != null)
                Console.ForegroundColor = this.savedForeground.Value;

            if (this.savedBackground != null)
                Console.BackgroundColor = this.savedBackground.Value;
        }

        public override FluentConsole.IAfterColorSyntax Color(ConsoleColor color) {
            return new ColorScope(color, this.background);
        }
    }
}