void Zadacha25()
{
 // Используя определение степени числа, напишите цикл, который принимает на вход
 // два натуральных числа (A и B) и возводит число A в степень B.

 Random random = new Random();
 int A = random.Next(2,11);
 int B = random.Next(2,11);
 Console.WriteLine("Число A: " + A);
 Console.WriteLine("Число B: " + B);
 int result = A;

 for (int i = 1; i < B; i++)
 {
    result *= A;
 }
 Console.WriteLine($"Число А в степени В: {result}");
}


void Zadacha27()
{
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Random random = new Random();
    int number = random.Next(10,1000000);
    Console.WriteLine("Задано число: " + number);
    int sum = 0;

    while (number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр заданного числа равна {sum}");
}


void Zadacha29()
{
    // Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит
    // отсортированный по модулю массив.

    int size = 8;
    int[] array = new int [size];

    Random random = new Random();
    Console.WriteLine("Случайный массив:");
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(-10,11);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    for (int i = size-1; i > 0; i--)
    {
         for (int j = 0; j < i; j++)
        {
            if(Math.Abs(array[j]) > Math.Abs(array[j+1]))
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
    
    Console.WriteLine("Отсортированный массив: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


//Zadacha25();
//Zadacha27();
Zadacha29();