namespace VehicleOOPNETApp.src
{
    public class Car : Vehicle
    {
        private int _doors;
        
        public Car(string brand, string model, int year, int power, string powerUnit, int doors) : base(brand, model, year, power, powerUnit)
        {
            _doors = doors;
        }

        public int Doors { get => _doors; }

        public override string ToString()
        {
            return $"Car Brand: {_brand}, Model: {_model}, Year: {_year}, Power: {_power}{_powerUnit}, Doors: {_doors}";
        }
    }
}