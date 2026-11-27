class RemoteControlCar
{
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    int distance = 0;
    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    int battery = 100;
    public string BatteryDisplay()
    {
        if (battery > 0){
            return $"Battery at {battery}%";
        }
        return "Battery empty";
    }

    public void Drive()
    {
        if (battery != 0){    
            distance += 20;
            battery -= 1;
        }
    }
}
