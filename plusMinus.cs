class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count;
        int positiveCount = 0, negativeCount = 0, zeroCount = 0;

        foreach (int num in arr)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
            else
                zeroCount++;
        }

        // Print the ratios with 6 decimal places
        Console.WriteLine(((double)positiveCount / n).ToString("F6"));
        Console.WriteLine(((double)negativeCount / n).ToString("F6"));
        Console.WriteLine(((double)zeroCount / n).ToString("F6"));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().Trim().Split(' ')
            .Select(int.Parse).ToList();

        Result.plusMinus(arr);
    }
}
