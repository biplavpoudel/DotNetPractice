int a = 10; // 00001010
int b = 6;  // 00000110
WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); // 2-bit column only e.g. 00000010
WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns e.g. 00001110
WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns e.g. 00001100