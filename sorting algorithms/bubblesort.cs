static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                // Swap arr[j] and arr[j+1]
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }  //end if
        }//end for 1
    }//for loop
}


// call the program
int[] arr = { 5, 2, 4, 6, 1, 3 };
BubbleSort(arr);
foreach (int i in arr)
{
    Console.Write(i + " ");
}
