namespace HomeWorkSeminar5LanguageProgramm;

class Program
{
    static void Main(string[] args)
    {
        void task34()
        {
            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
            // которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2

            int[] array = MyLib.FillRandomArrayPositive3xNumbers();
            MyLib.PrintArray(array);
            Console.WriteLine("Количество четных элементов в вашем массиве = " + MyLib.FindQuantityEvenNumberArray(array));
        }

        void task36()
        {
            // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6] -> 0

            int length = MyLib.Input("Введите  число на какое количество элементов заполнить ваш массив: ");

            int[] array = MyLib.FillRandomArray(length);
            MyLib.PrintArray(array);
            int sumElementsOddIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sumElementsOddIndex += array[i];
            }
            Console.WriteLine($"Сумма ваших элементов c нечетными индексами равна {sumElementsOddIndex}");


        }

        void task38()
        {
            // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
            //[3,21 7,04 22,93 -2,71 78,24] -> 80,95

            double[] array = { 3.21, 7.04, 22.93, -2.71, 78.24 };
            double min = array[0];
            double max = array[0];  
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max ) max = array[i];
                if(array[i] < min)  min = array[i];
            }
            Console.WriteLine($" Разница между максимальным {max} и минимальным {min} элементами массива равна {Math.Round(max-min,2)}");
            Console.WriteLine($"{max} - {min} =  {Math.Round(max -min,2)}");
        }

          Console.Clear();
        Console.WriteLine("Введите номер задачи 34, 36 или 38");
        int task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 34: task34(); break;
            case 36: task36(); break;
            case 38: task38(); break;
            default: Console.WriteLine("Задачи с таким номером не существует!"); break;
        }

    }
}
