using System;
using System.Collections.Generic;
using System.ComponentModel;
using JetBrains.Annotations;

// ReSharper disable CheckNamespace
// ReSharper disable MethodOverloadWithOptionalParameter

partial class FluentConsole {
    /// <summary>
    /// Main fluent interface.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial interface IMainSyntax : ITextSyntax {
        /// <summary>
        /// Writes a new line to the console (same as <see cref="Console.WriteLine()"/>).
        /// </summary>
        [NotNull]
        IMainSyntax NewLine();

        /// <summary>
        /// Sets the foreground color for future calls to <see cref="FluentConsole.ITextSyntax"/>.Text and <see cref="FluentConsole.ITextSyntax"/>.Line.
        /// Only applies to calls made on instance it returns.
        /// </summary>
        [NotNull]
        IAfterColorSyntax Color(ConsoleColor color);

        /// <summary>
        /// Applies <paramref name="transform" /> to the current instance and returns its result.
        /// May be useful to set the color conditionally, for example.
        /// </summary>
        TSyntax With<TSyntax>([NotNull, InstantHandle] Func<IMainSyntax, TSyntax> transform);
    }

    /// <summary>
    /// Fluent interface used to write text on the console.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface ITextSyntax {
        /// <summary>
        /// Writes an object to the console (same as <see cref="Console.Write(object)"/>).
        /// </summary>
        [NotNull]
        IMainSyntax Text(object value);

        /// <summary>
        /// Writes a string to the console (same as <see cref="Console.Write(string)"/>).
        /// </summary>
        [NotNull]
        IMainSyntax Text(string value);

        /// <summary>
        /// Writes a formatted string to the console (same as <see cref="Console.Write(string, object[])"/>).
        /// </summary>
        [NotNull]
        [StringFormatMethod("format")]
        IMainSyntax Text(string format, params object[] args);

        /// <summary>
        /// Writes an object to the console (same as <see cref="Console.WriteLine(object)"/>).
        /// </summary>
        [NotNull]
        IMainSyntax Line(object value);

        /// <summary>
        /// Writes a string to the console (same as <see cref="Console.WriteLine(string)"/>).
        /// </summary>
        [NotNull]
        IMainSyntax Line(string value);

        /// <summary>
        /// Writes a formatted string to the console (same as <see cref="Console.WriteLine(string, object[])"/>).
        /// </summary>
        [NotNull]
        [StringFormatMethod("format")]
        IMainSyntax Line(string format, params object[] args);
    }

    /// <summary>
    /// Fluent interface with only methods available after <see cref="IMainSyntax.Color" /> call.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IAfterColorSyntax : ITextSyntax {
        /// <summary>
        /// Applies current color selection to the background instead of the foreground.
        /// </summary>
        [NotNull]
        IMainSyntax Background { get; }
    }
}
