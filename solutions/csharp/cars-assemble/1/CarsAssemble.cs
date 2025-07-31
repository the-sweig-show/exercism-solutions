static class AssemblyLine
{
    private const double minProductionRate = 221.0;
    
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0.0;
        else if (speed >= 1 && speed <= 4)
            return 1.0;
        else if (speed >= 5 && speed <= 8)
            return 0.9;
        else if (speed == 9)
            return 0.8;
        else
            return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double grossRatePerHour = minProductionRate * speed;
        return grossRatePerHour * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double carsPerHour = ProductionRatePerHour(speed);
        return (int)Math.Floor(carsPerHour / 60);
    }
}
