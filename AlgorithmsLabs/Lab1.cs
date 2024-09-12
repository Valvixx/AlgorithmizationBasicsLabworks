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
            if (array[l] > max)
            {
                max = array[l];
            }
        }

        foreach (var l in array)
        {
            if (array[l] < min)
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

    public static void Task4()
    {
        int[,] array =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += array[i, j];
            }

            Console.WriteLine($"Сумма строки {i + 1}: {rowSum}");
        }
    }

    public static void Task5()
    {
        Student[] students = new Student[]
        {
            new Student("Иван", "Десятов", "ФВТ", 121231233),
            new Student("Никита", "Петров", "ФВТ", 12341412),
            new Student("Сергей", "Сергеев", "ФИТЭ", 331135132),
            new Student("Мария", "Иванова", "ФВТ", 454234232)
        };

        Console.WriteLine("Введите имя для поиска:");
        string searchFirstName = Console.ReadLine();
        Console.WriteLine("Введите фамилию для поиска:");
        string searchLastName = Console.ReadLine();

        Student? foundStudent = FindStudent(students, searchFirstName, searchLastName);

        if (foundStudent != null)
        {
            Console.WriteLine("Студент найден:");
            foundStudent.Value.Display();
        }
        else
        {
            Console.WriteLine("Студент не найден.");
        }
    }

    static Student? FindStudent(Student[] students, string firstName, string lastName)
    {
        foreach (var student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                return student;
            }
        }

        return null;
    }
}

struct Student
{
    public string FirstName, LastName, Faculty;
    public int RecordBookNumber;

    public Student(string firstName, string lastName, string faculty, int recordBookNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Faculty = faculty;
        this.RecordBookNumber = recordBookNumber;
    }

    public void Display()
    {
        Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Факультет: {Faculty}," +
                          $" Номер зачётки: {RecordBookNumber}");
    }
}