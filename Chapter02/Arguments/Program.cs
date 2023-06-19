WriteLine($"There are {args.Length} arguments:");

foreach (string arg in args)
{
    WriteLine( arg );
}

if  ( args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size.");
    WriteLine("e.g. dotnet run red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(    //converts string representation of enum (i.e.args[0]) into actual enum
    enumType: typeof( ConsoleColor ),          //and passes to ForegroundColor property of System.Console Class
    value: args[0],
    ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(    
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true);

//CursorSize = int.Parse(args[2]);     //converts string representation of int (i.e.args[2]) into actual int
//and passes to CursorSize property of System.Console Class
try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");
}

