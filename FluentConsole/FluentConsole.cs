using System;
using System.Collections.Generic;
using FluentConsoleInternal;
using JetBrains.Annotations;

// ReSharper disable CheckNamespace
// ReSharper disable MethodOverloadWithOptionalParameter

/// <summary>
/// Provides fluent API over console methods (mostly color-related).
/// </summary>
public static partial class FluentConsole {
    private static readonly MainSyntax instance = new MainSyntax();

    /// <summary>
    /// Returns an instance of the FluentConsole syntax.
    /// Always returns the same instance. Rarely needed.
    /// </summary>
    [NotNull]
    public static IMainSyntax Instance {
        get { return instance; }
    }

    /// <summary>
    /// Writes an object to the console (same as <see cref="Console.Write(object)"/>).
    /// </summary>
    [NotNull]
    public static IMainSyntax Text(object value) {
        return instance.Text(value);
    }

    /// <summary>
    /// Writes a string to the console (same as <see cref="Console.Write(string)"/>).
    /// </summary>
    [NotNull]
    public static IMainSyntax Text(string value) {
        return instance.Text(value);
    }

    /// <summary>
    /// Writes a formatted string to the console (same as <see cref="Console.Write(string, object[])"/>).
    /// </summary>
    [NotNull]
    [StringFormatMethod("format")]
    public static IMainSyntax Text(string format, params object[] args) {
        return instance.Text(format, args);
    }

    /// <summary>
    /// Writes an object to the console (same as <see cref="Console.WriteLine(object)"/>).
    /// </summary>
    [NotNull]
    public static IMainSyntax Line(object value) {
        return instance.Line(value);
    }

    /// <summary>
    /// Writes a string to the console (same as <see cref="Console.WriteLine(string)"/>).
    /// </summary>
    [NotNull]
    public static IMainSyntax Line(string value) {
        return instance.Line(value);
    }

    /// <summary>
    /// Writes a formatted string to the console (same as <see cref="Console.WriteLine(string, object[])"/>).
    /// </summary>
    [NotNull]
    [StringFormatMethod("format")]
    public static IMainSyntax Line(string format, params object[] args) {
        return instance.Line(format, args);
    }

    /// <summary>
    /// Writes a new line to the console (same as <see cref="Console.WriteLine()"/>).
    /// </summary>
    [NotNull]
    public static IMainSyntax NewLine() {
        return instance.NewLine();
    }

    /// <summary>
    /// Sets the foreground color for future calls to <see cref="ITextSyntax"/>.Text and <see cref="ITextSyntax"/>.Line.
    /// Only applies to calls made on instance it returns.
    /// </summary>
    [NotNull]
    public static IAfterColorSyntax Color(ConsoleColor color) {
        return instance.Color(color);
    }

    /// <summary>
    /// Applies <paramref name="transform" /> to <see cref="Instance"/> and returns its result.
    /// May be useful to set the color conditionally, for example.
    /// </summary>
    public static TSyntax With<TSyntax>([NotNull, InstantHandle] Func<IMainSyntax, TSyntax> transform) {
        return transform(Instance);
    }
}
