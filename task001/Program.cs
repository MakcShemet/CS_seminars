Console.WriteLine("Input tow number:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int square = a * a;
if (square == b)
{
    Console.WriteLine("Число " + a + "явлется квадратом " + b);
}
else {Console.WriteLine("Число " + a + "не явлется квадратом " + b);
}
