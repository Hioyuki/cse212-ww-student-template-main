using System.Diagnostics;

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

        // Prepare an array with the specified length
        double[] numbers = new double[length];

        // Loop through and assign each element
        for (int i = 0; i < length; i++)
        {
            // Since i is zero-based, multiply by (i + 1) to get 1x, 2x, 3x, ...
            numbers[i] = number * (i + 1);

            // Example: number = 7, i = 0 -> numbers[0] = 7 * 1 = 7
            //          number = 7, i = 1 -> numbers[1] = 7 * 2 = 14
        }

        // Return the completed array
        return numbers;

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
        // 1. Extract the last 'amount' elements from the list
        List<int> sublist = data.GetRange(data.Count - amount, amount);

        // 2. Remove the last 'amount' elements from the original list
        data.RemoveRange(data.Count - amount, amount);

        // 3. Insert the extracted elements at the beginning of the list
        data.InsertRange(0, sublist);
        //debag test
        Debug.WriteLine("List after rotation: " + string.Join(", ", data));

    }
}
