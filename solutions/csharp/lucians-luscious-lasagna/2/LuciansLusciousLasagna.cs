class Lasagna
{
    // DONE: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // DONE: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutesInOven) => this.ExpectedMinutesInOven() - actualMinutesInOven;
    // DONE: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers) => 2 * numberOfLayers;
    // DONE: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => this.PreparationTimeInMinutes(layers) + minutesInOven;
}
