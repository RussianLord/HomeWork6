void HW1()
{
    Console.WriteLine("Программа покажет количество чисел больше 0, которые ввёл пользователь...");
    Console.WriteLine("Введите размер массива...");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(size, numbers);
    PrintArray(numbers);
    CheckArray(numbers);
}

void FillArray(int size, int[] numbers)
{
    Console.WriteLine("Введите разные числа с учётом размера массива <" + size + ">");
    for(int i = 0; i < numbers.Length; i++)
    {
        int insert = Convert.ToInt32(Console.ReadLine());
        numbers[i] = insert;
    }
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Получили данный массив.");
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void CheckArray(int[] numbers)
{
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine($"Количество чисел в массиве являются больше 0 ----> ({sum}).");
}


void HW2()
{
    Console.WriteLine("Данная программа рассчитывает точку пересечения двух прямых...");
    Console.WriteLine("Введите число B1...");
    double B1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число K1...");
    double K1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B2...");
    double B2 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите число K2...");
    double K2 = Convert.ToInt32(Console.ReadLine());  
    Algoritm(B1, K1, B2, K2);
    
}

void Algoritm(double B1, double K1, double B2, double K2)
{
    double X = (B2-B1)/(K1-K2);
    double Y1 = K1 * X + B1;
    double Y2 = K2 * X + B2;
    if(Y1 == Y2)
    {
        Console.WriteLine($"Для заданных значений B1 = {B1}, K1 = {K1}, B2 = {B2}, K2 = {K2}, получаем Х равный {X}");
        Console.WriteLine($"Поэтому из расчётов прямой получаем (Y1; Y2) = ({Y1}; {Y2})");
    }
    else
    {
        Console.WriteLine("Точка пересечения не найдена");
    }
}

HW1();
// HW2();