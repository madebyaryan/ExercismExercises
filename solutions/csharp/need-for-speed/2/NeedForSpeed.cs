class RemoteControlCar
{
    private int speed;
    private int batteryDrainPercentage;
    public int currentBatteryPercentage = 100;
    public int metersDriven = 0;

    public RemoteControlCar(int speed, int batteryDrainPercentage)
    {
        this.speed = speed;
        this.batteryDrainPercentage = batteryDrainPercentage;
    }

    public bool BatteryDrained()
    {
        return (currentBatteryPercentage < this.batteryDrainPercentage);
    }

    public int DistanceDriven() => metersDriven;

    public void Drive()
    {
        if (currentBatteryPercentage >= this.batteryDrainPercentage)
        {
            metersDriven += speed;
            currentBatteryPercentage -= this.batteryDrainPercentage;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    public int trackDistance;

    public RaceTrack(int trackDistance)
    {
        this.trackDistance = trackDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (this.trackDistance >= car.DistanceDriven() && !car.BatteryDrained())
        {
            car.Drive();
        }
        return car.DistanceDriven() >= this.trackDistance;   
    }
}
