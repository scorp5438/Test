string[] array = {"Hello", "2", "world", ":-)"};

int FindLen(string[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            res++;
        }
    }
    return res;
}
