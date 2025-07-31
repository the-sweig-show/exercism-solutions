class Lasagna
{
    // DONE: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // DONE: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return this.ExpectedMinutesInOven() - actualMinutesInOven;    
    }
    // DONE: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return 2 * numberOfLayers;
    }
    // DONE: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return this.PreparationTimeInMinutes(layers) + minutesInOven;
    }
}
