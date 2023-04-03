//напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

string Read()
{
    System.Console.WriteLine("Введите число");
    string txt = Console.ReadLine();
    return txt;
}

string input = Read();
if (input.Length != 5)
{
    Console.WriteLine("Введенное число не является 5 значным");
    return;
}

string reversed = string.Empty;
for (int i = 4; i >= 0; i--)
{
    reversed += input[i];
}

if (reversed == input)
{
    Console.WriteLine($"{input} -> да");
}
else
{
    Console.WriteLine($"{input} -> нет");
}


