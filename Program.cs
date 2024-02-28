// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Name: Tanuj Ajitpratap Singh
//Date: 28th February 2024
//This code implements bubble sort algorithm on the input array.


//input array
int[] arr = { 5, 72, 3, 14, 7, 1};

//function call to implement bubbleSort
bubbleSort(arr);

//Print the sorted array
Console.WriteLine("After bubble sort");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write("  " + arr[i]);
}
//bubblesort function declaration with implementation
static void bubbleSort(int[] arr)
{
    //outer loop for iterating over the input array
    for(int i = 0; i < arr.Length; i++)
    {
        //inner loop to work on sorting with respect to each element
        for(int j = 0; j < arr.Length - i - 1; j++)
        {
            //comparing adjacent values
            if (arr[j+1] < arr[j])
            {
                //swapping values
                int temp = arr[j+1];
                arr[j+1] = arr[j]; 
                arr[j] = temp;
            }
        }
    }
}



