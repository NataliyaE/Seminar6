// пользователь вводит с клавиатуры М чисел. посчитать, сколько чисел больше нуля введено


Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Кол-во элементов больше нуля = {FindCount(array)}");

void FillArray(int[] array)
{
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        int arrayElement = Convert.ToInt32(Console.ReadLine());
        array[i] = arrayElement;
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{array[index]}; ");
        index ++;
    }
}

int FindCount(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0)
       {
            result ++;
       }
    }
    return result;
}