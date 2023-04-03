//напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

int Read()
{
    System.Console.WriteLine("Введите число");
    int x = int.Parse(Console.ReadLine());
    return x;
}

void Print()
{
    int y = Read();
    for (int i = 1; i <= y; i++)
    {
        System.Console.WriteLine(Math.Pow(i, 3));
    }
}

Print();
