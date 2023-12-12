string[] array = {"Hello", "2", "world", ":-)"};

string[] newArray = new string[FindLen(array)];

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

void CreateNewArray(string[] oldarr, string[] newarr)
{
    int index = 0;
    for (int i = 0; i < oldarr.Length; i++)
    {
        if (oldarr[i].Length <=3)
        {
            newarr[index] = oldarr[i];
            index++;
        }
    }
}