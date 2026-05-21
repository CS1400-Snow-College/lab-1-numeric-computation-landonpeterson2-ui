//WorkWithIntegers();
//OrderPrecedence();
WorkWithDoubles();




void WorkWithDoubles()
{
double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

double a2 = 450.0;
double b2 = 950.0;
double c2 = 1750.0;
double d2 = a2 * b2 / c2;
Console.WriteLine(d2);
}

void WorkWithIntegers()
{
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

c = a - b;
Console.WriteLine(c);

c= a * b;
Console.WriteLine(c);

c = a / b;
Console.WriteLine(c);

c = a + b - 12 * 17;
Console.WriteLine(c);

}

void OrderPrecedence()
{   
int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 *4) / 3 + 12;
Console.WriteLine(d);

int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g;
Console.WriteLine(h);

int a2 = 7;
int b2 = 4;
int c2 = 3;
int d2 = (a2 + b2) / c2;
int e2 = (a2 + b2) % c2;
Console.WriteLine($"quotient: {d2}");
Console.WriteLine($"remainder: {e2}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
}