//using static System.Console;    //now no need to enter Console.WriteLine or Console.ReadLine
//Implicitly called in .csproj file


//WriteLine(                                              //named arguments i.e.arg0 cannot be
//    format: "{0} lives in {1} and he is {2} in the world.",        //used for more than 4 variables
//    arg0: "Biplav",
//    arg1: "Seattle",
//    arg2: "the most powerful human"
//);

//WriteLine(
//    format: "{0} lives in {1} and he is {2} in the world.",
//    "Biplav", "Seattle", "the most powerful human"
//);

//int numberofApples = 13;
//decimal priceperApple = 2.35M;

//string formatted_string = String.Format(
//    format: "{0} string costs {1}.",
//    arg0: numberofApples,
//    arg1: priceperApple * numberofApples);

//string formatted_string1 = String.Format(
//    format: "{0} string costs {1}.",
//    numberofApples, priceperApple * numberofApples);

//string fname = "Biplav";
//string lname = "Poudel";
//WriteLine(fname + " " + lname);
//WriteLine($"{fname}{lname}");
//WriteLine($"{fname} {lname}");

//string applesText = "Apples";
//float applesCount = 1234.678F;
//string text = "Ananasa";

//WriteLine(
//format: "{0,-10} {1,7}",      //positive int means right aligned and negative means left aligned with width of int
//arg0: "Name",
//arg1: "Count");

//WriteLine(
//format: "{0,-10} {1,7:N1}",
//arg0: applesText,
//arg1: applesCount);

//WriteLine(
//format: "{0,-10} {1,7:N0}",
//arg0: text,
//arg1: applesCount);

//WriteLine("Enter your name here:");
//string? name = ReadLine()!;

//WriteLine("Enter your age here:");
//string? age = ReadLine()!;

//WriteLine($"Hello {name}, you look good at the age of {age}.");

Write("Enter any key combination:");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
   arg0: key.Key,
   arg1: key.KeyChar,
   arg2: key.Modifiers);