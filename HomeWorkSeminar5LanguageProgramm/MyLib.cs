class MyLib
{
    public static int Input(string text)
    {
        Console.WriteLine(text);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    public static int[] FillRandomArrayPositive3xNumbers()
    {
        Console.WriteLine("Введи размер массива: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Этот маасив будет заполнен случайными трехзначными положительными числами на {userNumber} элементов!");
        Random random = new Random();
        int[] array = new int[userNumber];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }
        return array;

    }
    public static int FindQuantityEvenNumberArray(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count++;
        }
        return count;
    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ",");
        }
        Console.WriteLine();
    }
    public static int[] FillRandomArray(int number)
    {
       
        int[] array = new int[number];
        Random random= new Random();
        Console.WriteLine($" ваш массив будет заполнен случайными числами от -100 до 100 на {number} элементов!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100,100);
        }
        return array;
    }
}
