namespace VehicleOOPNETApp.src
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string model, int year, int power, string powerUnit) : base(brand, model, year, power, powerUnit)
        {
        }

        public override string ToString()
        {
            return $"Motorcycle Brand: {_brand}, Model: {_model}, Year: {_year}, Power: {_power}{_powerUnit}";
        }
    }
}