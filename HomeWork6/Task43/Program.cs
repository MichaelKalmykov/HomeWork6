double b1 = UserInputNumbers("Введите значение для b1 ");
double k1 = UserInputNumbers("Введите значение для k1 ");
double b2 = UserInputNumbers("Введите значение для b2 ");
double k2 = UserInputNumbers("Введите значение для k2 ");
double x = (b2 - b1)/(k1 - k2);
double y = k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine("Координаты точки пересечения: [" + x + ";" + y + "]");

double UserInputNumbers (string numbers)
{
    Console.Write(numbers);
    return Convert.ToDouble(Console.ReadLine());
} 
