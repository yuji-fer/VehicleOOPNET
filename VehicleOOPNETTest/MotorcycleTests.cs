using VehicleOOPNETApp.src;

namespace VehicleOOPNETTest
{
    public class MotorcycleTests
    {
        [
            Theory,
            InlineData("Honda", "Biz", 2012, 100, "CC"),
            InlineData("Honda", "Hornet", 2012, 600, "CC")
        ]
        public void ToString_FilledMotorcycle_ReturnAllMotorcycleInformationAsString(string brand, string model, int year, int power, string powerUnit)
        {
            Motorcycle motorcycle = new Motorcycle(brand, model, year, power, powerUnit);

            var result = motorcycle.ToString();

            Assert.Equal($"Motorcycle Brand: {brand}, Model: {model}, Year: {year}, Power: {power}{powerUnit}", result);
        }

        [
            Theory,
            InlineData("Honda", "Biz", 2012, 100, "CC"),
            InlineData("Honda", "Hornet", 2012, 600, "CC")
        ]
        public void ToStringWithTrueParameter_FilledMotorcycle_ReturnShortedMotorcycleInformationAsString(string brand, string model, int year, int power, string powerUnit)
        {
            Motorcycle motorcycle = new Motorcycle(brand, model, year, power, powerUnit);

            var result = motorcycle.ToString(true);

            Assert.Equal($"Brand: {brand}, Model: {model}", result);
        }

        [
            Theory,
            InlineData("Honda", "Biz", 2012, 100, "CC"),
            InlineData("Honda", "Hornet", 2012, 600, "CC")
        ]
        public void ToStringWithFalseParameter_FilledMotorcycle_ReturnAllMotorcycleInformationAsString(string brand, string model, int year, int power, string powerUnit)
        {
            Motorcycle motorcycle = new Motorcycle(brand, model, year, power, powerUnit);

            var result = motorcycle.ToString(false);

            Assert.Equal($"Motorcycle Brand: {brand}, Model: {model}, Year: {year}, Power: {power}{powerUnit}", result);
        }

        [
            Theory,
            InlineData("Honda"),
            InlineData("Yamaha")
        ]
        public void BrandProperty_FilledMotorcycle_FilledProperty(string brand)
        {
            Motorcycle motorcycle = new Motorcycle(brand, "model", 2012, 100, "HP");

            var result = motorcycle.Brand;

            Assert.Equal(brand, result);
        }

        [
            Theory,
            InlineData("Biz"),
            InlineData("Hornet")
        ]
        public void ModelProperty_FilledMotorcycle_FilledProperty(string model)
        {
            Motorcycle motorcycle = new Motorcycle("brand", model, 2012, 100, "HP");

            var result = motorcycle.Model;

            Assert.Equal(model, result);
        }

        [
            Theory,
            InlineData(2012),
            InlineData(2010)
        ]
        public void YearProperty_FilledMotorcycle_FilledProperty(int year)
        {
            Motorcycle motorcycle = new Motorcycle("brand", "model", year, 100, "HP");

            var result = motorcycle.Year;

            Assert.Equal(year, result);
        }

        [
            Theory,
            InlineData(100),
            InlineData(200)
        ]
        public void PowerProperty_FilledMotorcycle_FilledProperty(int power)
        {
            Motorcycle motorcycle = new Motorcycle("brand", "model", 2012, power, "HP");

            var result = motorcycle.Power;

            Assert.Equal(power, result);
        }

        [
            Theory,
            InlineData("HP"),
            InlineData("CC")
        ]
        public void PowerUnitProperty_FilledMotorcycle_FilledProperty(string powerUnit)
        {
            Motorcycle motorcycle = new Motorcycle("brand", "model", 2012, 100, powerUnit);

            var result = motorcycle.PowerUnit;

            Assert.Equal(powerUnit, result);
        }
    }
}