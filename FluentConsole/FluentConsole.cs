using System;
using System.Collections.Generic;
using System.ComponentModel;
using FluentConsoleInternal;

// ReSharper disable CheckNamespace
public static partial class FluentConsole {
// ReSharper restore CheckNamespace
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial interface IMainSyntax : ITextSyntax {
        [NotNull] IMainSyntax NewLine();

        [NotNull] IAfterColorSyntax Color(ConsoleColor color);
        TSyntax With<TSyntax>([NotNull, InstantHandle] Func<IMainSyntax, TSyntax> func);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface ITextSyntax {
        [NotNull] IMainSyntax Text(object value);
        [NotNull] IMainSyntax Text(string value);

        [NotNull]
        [StringFormatMethod("format")]
        // ReSharper disable MethodOverloadWithOptionalParameter
        IMainSyntax Text(string format, params object[] args);
        // ReSharper restore MethodOverloadWithOptionalParameter

        [NotNull] IMainSyntax Line(object value);
        [NotNull] IMainSyntax Line(string value);

        [NotNull]
        [StringFormatMethod("format")]
        // ReSharper disable MethodOverloadWithOptionalParameter
        IMainSyntax Line(string format, params object[] args);
        // ReSharper restore MethodOverloadWithOptionalParameter
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IAfterColorSyntax : ITextSyntax {
        [NotNull] IMainSyntax Background { get; }
    }

    private static readonly MainSyntax instance = new MainSyntax();

    [NotNull]
    public static IMainSyntax Instance {
        get { return instance; }
    }

    [NotNull]
    public static IMainSyntax Text(object value) {
        return instance.Text(value);
    }

    [NotNull]
    public static IMainSyntax Text(string value) {
        return instance.Text(value);
    }

    [NotNull]
    [StringFormatMethod("format")]
    // ReSharper disable MethodOverloadWithOptionalParameter
    public static IMainSyntax Text(string format, params object[] args) {
    // ReSharper restore MethodOverloadWithOptionalParameter
        return instance.Text(format, args);
    }

    [NotNull]
    public static IMainSyntax Line(object value) {
        return instance.Line(value);
    }

    [NotNull]
    public static IMainSyntax Line(string value) {
        return instance.Line(value);
    }

    [NotNull]
    [StringFormatMethod("format")]
    // ReSharper disable MethodOverloadWithOptionalParameter
    public static IMainSyntax Line(string format, params object[] args) {
        // ReSharper restore MethodOverloadWithOptionalParameter
        return instance.Line(format, args);
    }

    [NotNull]
    public static IMainSyntax NewLine() {
        return instance.NewLine();
    }

    [NotNull]
    public static IAfterColorSyntax Color(ConsoleColor color) {
        return instance.Color(color);
    }

    public static TSyntax With<TSyntax>([NotNull, InstantHandle] Func<IMainSyntax, TSyntax> selector) {
        return selector(new MainSyntax());
    }
}
