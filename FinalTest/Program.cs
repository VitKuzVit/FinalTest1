class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел:");

        string input = Console.ReadLine();
        //принимает на вход текст в переменную input
        string[] inputArray = input.Split(' ');
        //Задаем массив inputArray равный значнию введенных данных пользователем(разделенный пробелом)
        

        Console.WriteLine("Результат:");
        Console.WriteLine(inputArray);
       Console.WriteLine(string.Join(", ", resultArray));
    }

    int count = 0; // переменная счетчик
        for (int i = 0; i < inputArray.Length; i++) //цикл FOR по длинне массива для определения длиины итогового массива
        {
            if (inputArray[i].Length <= 3)// условие: если длинна индекса массива меньше или равена 3 count +1
            {
                count++;
            }
        }

        