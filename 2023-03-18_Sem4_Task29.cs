//Задача 29: Напишите программу, которая будет создавать массив из 8 символов 
//и заполнять значениями от пользователя
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void InputArray(int[] array) //метод заполняет массив введенными элементами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray (int[] array) //метод выводит на экран элементы массива
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
Console.Write($"количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine($"Введите элементы массива ");
InputArray(array);
PrintArray(array);