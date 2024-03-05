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
       
    }