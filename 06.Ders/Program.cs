// See https://aka.ms/new-console-template for more information

int[] Arrays = { 5, 22, 75, -10, 16 };
int maximum = FindMax(Arrays);
Console.WriteLine($"Max number in array{maximum}");

int FindMax(int[] Array )
{
    int maxNumber = Array[0];
    for (int i = 1; i < Array.Length; i++)
    {
        if (maxNumber < Array[i])
        {
            maxNumber = Array[i];
        }
    }
    return maxNumber;
}
