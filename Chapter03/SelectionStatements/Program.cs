object o = "3";
o = 3;
int j = 4;
if (o is int i)    //pattern matching; 'is' operator checks if 'o' can be cast to int. if cast successful, assignment is done inherently.
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}
