// Считает сколько чисел больше 0 ввел пользователь

System.Console.WriteLine("Введите числа через пробел");

int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
void Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i]>0) sum++;
    }
    System.Console.WriteLine("");
    System.Console.WriteLine(sum);
}

Sum(array);