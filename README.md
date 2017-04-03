## Usage

### Static

    FluentConsole
	    .White.Background
        .Green.Line("Hello there!");
    
    FluentConsole
	    .White.Text("Fluent")
        .Red.Text("Console");

### Instance

    var console = FluentConsole.Instance;
    
    console.Blue.Line(1);
    console.Cyan.Line(2);

### Tips

#### Conditional

    FluentConsole
	    .White.Text("Result: ")
        .With(c => result.IsSuccess ? c.Green : c.Red)
        .Line(result.Code)

## NuGet
https://www.nuget.org/packages/FluentConsole/

    Install-Package FluentConsole
