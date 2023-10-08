namespace ExercismCSharp;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    { 
        HashSet<int> uniqueMultiples = new HashSet<int>();
        
        foreach (int multiple in multiples)
        {
            if(multiple != 0)
            {
                for (int index = multiple; index < max; index += multiple)
                {
                    uniqueMultiples.Add(index);
                }
            }
        }
        return uniqueMultiples.Sum();
    }
}