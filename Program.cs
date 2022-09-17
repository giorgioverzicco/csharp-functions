int[] numbers = { 2, 6, 7, 5, 3, 9 };

// 1
Console.WriteLine("Ecco la lista di numeri:");
StampaArray(numbers);

Console.WriteLine();

// 2
int[] squaredNumbers = ElevaArrayAlQuadrato(numbers);

Console.WriteLine("Ecco la lista originale di numeri:");
StampaArray(numbers);

Console.WriteLine("Ecco la lista di numeri al quadrato:");
StampaArray(squaredNumbers);

Console.WriteLine();

// 3
int sumOfNumbers = SommaElementiArray(numbers);
Console.WriteLine($"Ecco la somma di tutti i numeri: {sumOfNumbers}");

// 4
int sumOfSquaredNumbers = SommaElementiArray(squaredNumbers);
Console.WriteLine($"Ecco la somma di tutti i numeri che sono stati elevati al quadrato: {sumOfSquaredNumbers}");
    
void StampaArray(int[] array)
{
    Console.Write("[");

    int i;
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(",");
    }
    
    Console.Write(array[i]);
    
    Console.Write("]\n");
}

int Quadrato(int numero)
{
    return numero * numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] squareNumbers = new int[array.Length];
    array.CopyTo(squareNumbers, 0);
    
    for (int i = 0; i < squareNumbers.Length; i++)
    {
        squareNumbers[i] *= squareNumbers[i];
    }

    return squareNumbers;
}

int SommaElementiArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}