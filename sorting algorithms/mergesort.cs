static void MergeSort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int mid = (left + right) / 2;

        // Recursively sort left and right halves
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);

        // Merge the sorted halves
        Merge(arr, left, mid, right);
    }
}

 static void Merge(int[] arr, int left, int mid, int right)
{
    int n1 = mid - left + 1;
    int n2 = right - mid;

    // Create temporary arrays
    int[] L = new int[n1];
    int[] R = new int[n2];

    // Copy data to temporary arrays
    for (int i = 0; i < n1; ++i)
    {
        L[i] = arr[left + i];
    }
    for (int j = 0; j < n2; ++j)
    {
        R[j] = arr[mid + 1 + j];
    }

    // Merge the temporary arrays
    int k = left;
    int i = 0;
    int j = 0;
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    // Copy any remaining elements of L[] and R[] if there are any
    while (i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }
    while (j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
}

    int[] arr = { 5, 2, 4, 6, 1, 3 };
    MergeSort(arr, 0, arr.Length - 1);
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
