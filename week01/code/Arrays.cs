public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /*
        ok my idea is a loop with runs length amout of times
        every loop it will add (number*length) as a new double in a list
        then return it
        */

        List<double> result = new List<double>(); //creates list

        for (int i = 0; i < length; i++) 
        {
            result.Add(number*(i+1));//+1 makes it so that it doesn't start at 0 and actually gets the correct amount of multiples
        }


        return result.ToArray();
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /*
        get the range of the list (amount) items from the right 
        and add it to a new list
        */
        List<int> result = new List<int>();
        result.AddRange(data.GetRange(data.Count-amount,data.Count));
        //then get the range of the list up until then and add it to the end of the new one
        result.AddRange(data.GetRange(0, data.Count-amount));
        // then set the old list to the new list
        data = result;
    }
}
