int[] scores = { 89, 75, 72, 91, 100, 99, 82, 67 };
SelectionSort(scores);
Console.WriteLine(string.Join(", " , scores));

void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int min = i;
        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[min])
            {
                min = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[min];
        arr[min] = temp;
    }
}