using System;

class Program
{
    static void Main()
    {
        string originalString = "Original String";
        Console.WriteLine($"Original String: {originalString} (Memory Address: {GetMemoryAddress(originalString)})");

        string modifiedString = originalString;
        modifiedString = "Modified String";
        Console.WriteLine($"Modified String: {modifiedString} (Memory Address: {GetMemoryAddress(modifiedString)})");

        Console.WriteLine($"Original String after modification: {originalString} (Memory Address: {GetMemoryAddress(originalString)})");
    }

    static unsafe IntPtr GetMemoryAddress(string s)
    {
        fixed (char* ptr = s)
        {
            return (IntPtr)ptr;
        }
    }

}