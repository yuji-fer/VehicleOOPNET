namespace VehicleOOPNETApp.src
{
    public abstract class Vehicle
    {
        protected string _brand;
        protected string _model;
        protected int _year;
        protected int _power;
        protected string _powerUnit;

        protected Vehicle(string brand, string model, int year, int power, string powerUnit)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _power = power;
            _powerUnit = powerUnit;
        }

        public string Brand { get => _brand; }
        public string Model { get => _model; }
        public int Year { get => _year; }
        public int Power { get => _power; }
        public string PowerUnit { get => _powerUnit; }

        public abstract override string ToString();
        public string ToString(bool onlyBrandAndModel)
        {
            return (onlyBrandAndModel ? $"Brand: {_brand}, Model: {_model}" : this.ToString());
        }
    }
}