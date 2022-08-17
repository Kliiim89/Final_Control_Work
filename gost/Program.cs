Console.WriteLine("Написать программу, которая из имеющегося массива строк" +
" формирует массив из строк, длина которых меньше либо равна 3 символа." +
" Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.");

string UserInput = "";
string preResult = "";

Console.WriteLine("Введите ваш текст сюда:");
UserInput = Console.ReadLine() ?? "";

string[] Array = UserInput.Split(" ");

int count = 0;
while (count < Array.Length)
{
    if (Array[count].Length <= 3)
    {
        preResult = preResult + Array[count] + " ";
    }
    count++;
}

string[] result = preResult.Split(" ");
Console.WriteLine($"Элементов, длина которых <=3: {result.Length}\nВот они:");

foreach (string r in result)
{
    Console.Write(r + " ");
}
Console.WriteLine();