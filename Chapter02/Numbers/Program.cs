using System;

/*uint naturalNumber = 23;
int integerNumber = -23;
float realNumber = 2.3f;
double anotherRealNumber = 2.3;

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

WriteLine($"{decimalNotation == binaryNotation}");
WriteLine($"{binaryNotation == hexadecimalNotation}");

WriteLine($"Type int uses {sizeof(int)} bytes and can store numbers in the range { int.MinValue:N0} to {int.MaxValue:N0}.\n");

WriteLine($"Type double uses {sizeof(double)} bytes and can store numbers in the range { double.MinValue:N0} \t to \t {double.MaxValue:N0}.\n");
WriteLine($"Type decimal uses {sizeof(decimal)} bytes and can store numbers in the range { decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
*/

WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    WriteLine($"{a} + {b} does NOT equal {0.3}");
}


WriteLine("\n");

WriteLine("Using decimals:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    WriteLine($"{c} + {d} does NOT equal {0.3}");
}
