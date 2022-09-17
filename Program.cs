// OLD int[] numbers = { 2, 6, 7, 5, 3, 9 };

// BONUS
Console.WriteLine("Quanti numeri vuoi digitare?");
Console.Write("> ");

int maxInputs = Convert.ToInt32(Console.ReadLine());
int[] numbers = GetUserEnteredNumbers(maxInputs);

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

Console.WriteLine();

// extra fattoriale
Console.WriteLine("Digita il numero del quale vuoi calcolare il fattoriale:");
Console.Write("> ");
int numToCalculateFactorial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Fattoriale di {numToCalculateFactorial} = {factorial(numToCalculateFactorial)}");

// Functions

int[] GetUserEnteredNumbers(int maxNumbers)
{
    int[] numbers = new int[maxNumbers];
    
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("\nDigita un numero intero da aggiungere:");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
}
    
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
    int[] squareNumbers = (int[]) array.Clone();
    
    for (int i = 0; i < squareNumbers.Length; i++)
    {
        squareNumbers[i] = Quadrato(squareNumbers[i]);
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

// fattoriale
long factorial(int number)
{
    if (number <= 1)
    {
        return 1;
    }
    
    return number * factorial(number - 1);
}