class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int cookingTime = 40;
        return cookingTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remainingTime)
    {
        int cookingTime = 40;
        return cookingTime - remainingTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int time = 2;
        return time * layers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int ovenTime)
    {
        int prepTime = PreparationTimeInMinutes(layers);
        return prepTime + ovenTime;
    }
    
}
