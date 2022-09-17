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