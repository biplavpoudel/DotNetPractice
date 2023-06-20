bool a = true;
bool b = false;

WriteLine($" {a^a}");
WriteLine($" {a ^ b}");
WriteLine($" {b ^ a}");
WriteLine($" {b ^ b}");    //^ is XOR operator

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}

WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");   //this statement won't be printed unless the DoStuff() is executed. DoStuff() returns true and then only the statement is allowed to execute.
WriteLine($"b & DoStuff() = {b & DoStuff()}");
WriteLine();
WriteLine($"b && DoStuff() = {b && DoStuff()}");  //short-circuiting i.e. b is deemed false and DoStuff() is not executed