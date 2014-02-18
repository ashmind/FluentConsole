using System;
using JetBrains.Annotations;

// ReSharper disable CheckNamespace
namespace FluentConsoleInternal {
// ReSharper restore CheckNamespace
    internal partial class MainSyntax : FluentConsole.IMainSyntax {
        protected virtual void BeforeText() { }
        protected virtual void AfterText() { }

        public FluentConsole.IMainSyntax Text(object value) {
            BeforeText();
            try {
                Console.Write(value);
            }
            finally {
                AfterText();
            }
            return this;
        }

        public FluentConsole.IMainSyntax Text(string value) {
            BeforeText();
            try {
                Console.Write(value);
            }
            finally {
                AfterText();
            }
            return this;
        }

        [StringFormatMethod("format")]
        // ReSharper disable MethodOverloadWithOptionalParameter
        public FluentConsole.IMainSyntax Text(string format, params object[] args) {
        // ReSharper restore MethodOverloadWithOptionalParameter
            BeforeText();
            try {
                Console.Write(format, args);
            }
            finally {
                AfterText();
            }
            return this;
        }

        public FluentConsole.IMainSyntax Line(object value) {
            BeforeText();
            try {
                Console.WriteLine(value);
            }
            finally {
                AfterText();
            }
            return this;
        }

        public FluentConsole.IMainSyntax Line(string value) {
            BeforeText();
            try {
                Console.WriteLine(value);
            }
            finally {
                AfterText();
            }
            return this;
        }

        [StringFormatMethod("format")]
        // ReSharper disable MethodOverloadWithOptionalParameter
        public FluentConsole.IMainSyntax Line(string format, params object[] args) {
            // ReSharper restore MethodOverloadWithOptionalParameter
            BeforeText();
            try {
                Console.WriteLine(format, args);
            }
            finally {
                AfterText();
            }
            return this;
        }

        public FluentConsole.IMainSyntax NewLine() {
            Console.WriteLine();
            return this;
        }

        public virtual FluentConsole.IAfterColorSyntax Color(ConsoleColor color) {
            return new ColorScope(color, null);
        }

        public TSyntax With<TSyntax>(Func<FluentConsole.IMainSyntax, TSyntax> transform) {
            return transform(this);
        }
    }
}