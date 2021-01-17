namespace factory.method
{
    public class CarBuilder
    {
        public const int STREET = 1; 
        public const int SPORTS = 2; 

        public static Car Build(int carType)
        {
            switch (carType)
            {
                case STREET:
                    return new StreetCar();
                case SPORTS:
                    return new SportsCar();
                default:
                    return null;
            }
        }
    }
}