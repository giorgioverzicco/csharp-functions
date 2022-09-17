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