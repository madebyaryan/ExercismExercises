class RemoteControlCar
{
    public int batteryPercentage;
    public int distanceDriven;

    public RemoteControlCar()
    {
        this.batteryPercentage = 100;
        this.distanceDriven = 0;
    }
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        if (this.distanceDriven >= 0)
        {
            return $"Driven {this.distanceDriven} meters";
        }
        return "Distance empty";
    }

    public string BatteryDisplay()
    {
        if (this.batteryPercentage > 0)
        {
            return $"Battery at {this.batteryPercentage}%";
        }
        return "Battery empty";
    }

    public void Drive()
    {
        if (this.batteryPercentage > 0)
        {
            this.distanceDriven += 20;
            this.batteryPercentage -= 1;
        }
        else{
            this.batteryPercentage = this.batteryPercentage;
            this.distanceDriven = this.distanceDriven;
        }
    }
}
