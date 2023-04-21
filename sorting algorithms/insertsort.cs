static void InsertionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n; ++i)
    {
        int key = arr[i];
        int j = i - 1;
        // move elements of arr[0..i-1]
        // that are greater than the key to
        // one position ahead of their current position.
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        } //end while loop
        arr[j + 1] = key;
    }//end for looop
}//end insertionsort

// to call this insertion sort, you'll pass a set of array into
// the parameter

    int[] arr = {5,2,4,6,1,3};
    InsertionSort(arr);

    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }