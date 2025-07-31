class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[]{ 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return this.birdsPerDay[this.birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[this.birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birdCount in this.birdsPerDay)
        {
            if (birdCount == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCount = 0;
        if (numberOfDays >= 7)
        {
            foreach (int numBirds in this.birdsPerDay)
            {
                birdCount += numBirds;
            }
        }
        else
        {
            for (int i = 0; i < numberOfDays; i++) {
                birdCount += this.birdsPerDay[i];
            }
        }
        return birdCount;
    }

    public int BusyDays()
    {
        int numBusyDays = 0;
        foreach (int birdCount in this.birdsPerDay)
        {
            if (birdCount >= 5)
            {
                numBusyDays++;
            }
        }
        return numBusyDays;
    }
}
