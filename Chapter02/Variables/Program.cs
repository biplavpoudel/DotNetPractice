using System.Xml;

/*object height = 1.88;
object name = "Biplav";
WriteLine($"{name} is {height} meters tall.");

//int len1 = name.Length;
int len2 = ((string)name).Length;
WriteLine($"{name} has {len2} characters.");

dynamic something = new[] { 3, 4, 5 };
WriteLine($"\nThe length is : {something.Length}\n" );

//something = 13;
//WriteLine($"The length is : {something.Length}");

something = "Biplav";
Write($"The length is : {something.Length}");*/

var xml1 = new XmlDocument();               //good use of var
XmlDocument xml2 = new XmlDocument();
XmlDocument xml3 = new();       //"target-typed new"

var file1 = File.CreateText("hello.txt");       //bad use of var
StreamWriter file2 = File.CreateText("bye.txt");