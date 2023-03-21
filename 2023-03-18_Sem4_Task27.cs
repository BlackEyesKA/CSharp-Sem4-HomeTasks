//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string massage)
{
    System.Console.Write(massage); //выводим приглашение ко вводу
    string readInput = System.Console.ReadLine ();
    int result = int.Parse (readInput); //приводим к числу
    return result; //возвращаем результат
 }

 int SumAllDigit(int number)
 {
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
 }

 int number = Prompt("Введите число: ");
 System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");