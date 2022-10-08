int a = -9;
int b = -3;

int max = a;
int min = b;

if (b > max) max = b;
if (a < min) min = a;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);