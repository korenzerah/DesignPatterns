namespace DesignPatterns
{
    public static class VehicleFactory
    {
        public static Vehicle CreateVehicle(string s) {
            switch (s) {
                case("Car"): {
                    return new Car("Car", "1111");
                }
                case("Tank"): {
                    return new Tank("tank", "1925", "Koren");
                } default: {
                    return null;
                }
            }        
        }
    }
}