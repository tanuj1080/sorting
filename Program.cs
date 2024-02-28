// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//5,72,3,14,7,1


int[] arr = { 5, 72, 3, 14, 7, 1};
bubbleSort(arr);
Console.WriteLine("After bubble sort");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write("  " + arr[i]);
}
static void bubbleSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j+1] < arr[j])
            {
                int temp = arr[j+1];
                arr[j+1] = arr[j]; 
                arr[j] = temp;
            }
        }
    }
}



