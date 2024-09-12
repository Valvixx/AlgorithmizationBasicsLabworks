namespace AlgorithmsLabs;

public class Lab1
{
    public static void Task1()
    {
        int[] array = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        int max = int.MinValue;
        int min = int.MaxValue;

        foreach (var l in array)
        {
            if (array[l]>max)
            {
                max = array[l];
            }
        }

        foreach (var l in array)
        {
            if (array[l]<min)
            {
                min = array[l];
            }
        }

        int result = max - min;
        Console.WriteLine(result); 
    }

    public static void Task2()
    {
        int[] array = new int[5];
        foreach (var l in array)
        {
            array[l] = new Random().Next(-1000, 1000);
            Console.WriteLine(array[l]);
        }
    }

    public static void Task3()
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        
        Console.WriteLine($"Array size: {array.Length}");
    }
}