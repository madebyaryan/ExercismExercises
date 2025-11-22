class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeeksBirds = new int[7];
        lastWeeksBirds[0] = 0;
        lastWeeksBirds[1] = 2;
        lastWeeksBirds[2] = 5;
        lastWeeksBirds[3] = 3;
        lastWeeksBirds[4] = 7;
        lastWeeksBirds[5] = 8;
        lastWeeksBirds[6] = 4;
        return lastWeeksBirds;
    }

    public int Today()
    {
        return this.birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var item in this.birdsPerDay)
        {
            if (item == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            counter += this.birdsPerDay[i];
        }
        return counter;
    }

    public int BusyDays()
    {
        int numOfBusyDays = 0;
        foreach (var item in this.birdsPerDay)
        {
            if (item >= 5)
            {
                numOfBusyDays++;
            }
        }
        return numOfBusyDays;
    }
}
