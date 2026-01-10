public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> neww = new List<int>();
        foreach (int i in select)
        {
            neww.Add (i);
        }
        List<int> firstList = new List<int> ();
        for (int i = list1.Length-1; i>-1; i--)
        {
            firstList.Add (list1[i]);
        }
        List<int> secondList = new List<int> ();
        for (int i = list2.Length-1; i>-1; i--)
        {
            secondList.Add (list2[i]);
        }
        List<int> resulted = new List<int> ();
        foreach (int i in neww)
        {
            if (i == 1)
            {
                resulted.Add (firstList.Last ());
                firstList.RemoveAt(firstList.Count - 1);
            }
            if (i == 2)
            {
                resulted.Add (secondList.Last ());
                secondList.RemoveAt (secondList.Count - 1);
            }
        }
        return resulted.ToArray();
    }
}