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
        //  ------------IMPLEMENTATION---------- -

        //  To solve this problem I initialized an array that holds doubles. Then a variable 'i' in a 'for' loop that runs while the 
        //  variable 'i' is less than the product of number of multiples(length) we want to get
        //   and the start number(number) and then increment the variable 'i'  by the start number
        //   and then return the array.

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = (i + 1) * number;
        }
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
        //  ------------IMPLEMENTATION---------- -
    ///  
    /// // I created a variable and used the 'Skip' function on the list and passed the number of items in the list
    // (data.Count) minus the amount we want to rotate the list by as the parameter.
    // Then I created another variable and used the 'Take' function on the list and passed in the same parameter.
    // Then call the 'Clear' fuction on the list.
    // Then claaed the 'AddRange' function on the list and passed the two variables created earlier as parameter.
    public static void RotateListRight(List<int> data, int amount)
    {
        var rotatedPart = data.Skip(data.Count - amount).ToList();
        var remainingPart = data.Take(data.Count - amount).ToList();
        data.Clear();
        data.AddRange(rotatedPart);
        data.AddRange(remainingPart);
    }
}
