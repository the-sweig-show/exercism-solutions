public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
		if (max == 1)
		{
			return 1;
		}
		for (int i = 1; i <= max; i++)
		{
			sum += i;
		}
		return sum * sum; 
            
    }

    public static int CalculateSumOfSquares(int max)
    {
		int sum = 0;
		if (max == 1)
		{
			return 1;
		}
		for (int i = 1; i <= max; i++)
		{
			sum += i * i;
		}
		return sum;  
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}