static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0){
            return 0.00;
        } else if (speed >= 1 && speed <= 4){
            return 1.00;
        } else if (speed >=5 && speed <= 8){
            return 0.90;
        } else if (speed == 9){
            return 0.80;
        } else if (speed == 10){
            return 0.77;
        } 
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double rate = AssemblyLine.SuccessRate(speed);
        return rate * (speed * 221);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double rate = AssemblyLine.SuccessRate(speed);
        return (int)(rate * (speed * 221))/60;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}