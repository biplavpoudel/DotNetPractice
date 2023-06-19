/*using System.Reflection;
System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();
if (myApp == null) return;

foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);
    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes) methodCount += t.GetMethods().Count();


WriteLine(
    "{0:N0} types with {1:N0} methods in {2} Assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);
}*/

OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
WriteLine(grinningEmoji);

var person = new { FirstName = "Alice", Age = 56 };
string json = $$"""
{
"first_name": "{{person.FirstName}}",
"age": {{person.Age}},
"calculation", "{{{1 + 2}}}"
}
""";
WriteLine(json);