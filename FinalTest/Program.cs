using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");

        string input = Console.ReadLine();
        //принимает на вход текст в переменную input
        string[] inputArray = input.Split(' ');
        //Задаем массив inputArray равный значнию введенных данных пользователем(разделенный пробелом)
        string[] resultArray = GetStringsLengthLessThanOrEqualThree(inputArray);
        //Задаем массив resultArray с помощью функции GetStringsLengthLessThanOrEqualThree

        Console.WriteLine("Результат:");
        Console.WriteLine(inputArray);
        Console.WriteLine(string.Join(", ", resultArray));
    }

    static string[] GetStringsLengthLessThanOrEqualThree(string[] inputArray)
    {
        int count = 0; // переменная счетчик
        for (int i = 0; i < inputArray.Length; i++) //цикл FOR по длинне массива для определения длиины итогового массива
        {
            if (inputArray[i].Length <= 3)// условие: если длинна индекса массива меньше или равена 3 count +1
            {
                count++;
            }
        }

        string[] resultArray = new string[count];// массив строк resultArray принимает значение размера счетчика COUNT
        int index = 0; // переменная index
        for (int i = 0; i < inputArray.Length; i++) //цикл FOR по длинне массива для принятия новых значений
        {
            if (inputArray[i].Length <= 3)// условие: если индекс массива меньше или равен 3 
            {
                resultArray[index] = inputArray[i];// то в тело массива resultArray приваевается значение inputArray
                index++;
            }
        }

        return resultArray;
    }
}