int userLength = InputLengthUserArray("Введите длину массива ") ;
int [] arrayNumbers =  new int [userLength];
UserInputNumbers(arrayNumbers);
PrintArrayGreaterZero (arrayNumbers);

void UserInputNumbers (int [] arrayNumbers)
{
    for (int i = 0 ; i < arrayNumbers.Length ; i++)
    {
        Console.WriteLine($"Введите " + (i+1) +" номер: ");
        arrayNumbers [i] = Convert.ToInt16(Console.ReadLine()); 
    }

}
void PrintArrayGreaterZero (int [] arrayNumbers)
{
    int numbersGreaterZero = 0;
    Console.Write("Элементы больше нуля: (");
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0)
        {
            numbersGreaterZero++;

            Console.Write(" " + arrayNumbers[i] + " " );
        }
    }
    Console.Write(") Количество элементов больше нуля: " + numbersGreaterZero );
}
int InputLengthUserArray ( string lng)
{
    Console.Write (lng);
    return Convert.ToInt16(Console.ReadLine());
}