using VehicleOOPNETApp.src;

namespace VehicleOOPNETTest;

public class CarTests
{
    [
        Theory,
        InlineData("Ford", "Mustang", 2012, 300, "HP", 4),
        InlineData("Ford", "Edge", 2012, 100, "HP", 4)
    ]
    public void ToString_FilledCar_ReturnAllCarInformationAsString(string brand, string model, int year, int power, string powerUnit, int doors)
    {
        Car car = new Car(brand, model, year, power, powerUnit, doors);

        var result = car.ToString();

        Assert.Equal($"Car Brand: {brand}, Model: {model}, Year: {year}, Power: {power}{powerUnit}, Doors: {doors}", result);
    }

    [
        Theory,
        InlineData("Ford", "Mustang", 2012, 300, "HP", 4),
        InlineData("Ford", "Edge", 2012, 100, "HP", 4)
    ]
    public void ToStringWithTrueParameter_FilledCar_ReturnShortedCarInformationAsString(string brand, string model, int year, int power, string powerUnit, int doors)
    {
        Car car = new Car(brand, model, year, power, powerUnit, doors);

        var result = car.ToString(true);

        Assert.Equal($"Brand: {brand}, Model: {model}", result);
    }

    [
        Theory,
        InlineData("Ford", "Mustang", 2012, 300, "HP", 4),
        InlineData("Ford", "Edge", 2012, 100, "HP", 4)
    ]
    public void ToStringWithFalseParameter_FilledCar_ReturnAllCarInformationAsString(string brand, string model, int year, int power, string powerUnit, int doors)
    {
        Car car = new Car(brand, model, year, power, powerUnit, doors);

        var result = car.ToString(false);

        Assert.Equal($"Car Brand: {brand}, Model: {model}, Year: {year}, Power: {power}{powerUnit}, Doors: {doors}", result);
    }

    [
        Theory,
        InlineData("Ford"),
        InlineData("Chevrolet")
    ]
    public void BrandProperty_FilledCar_FilledProperty(string brand)
    {
        Car car = new Car(brand, "model", 2012, 100, "HP", 4);

        var result = car.Brand;

        Assert.Equal(brand, result);
    }

    [
        Theory,
        InlineData("Mustang"),
        InlineData("Edge")
    ]
    public void ModelProperty_FilledCar_FilledProperty(string model)
    {
        Car car = new Car("brand", model, 2012, 100, "HP", 4);

        var result = car.Model;

        Assert.Equal(model, result);
    }

    [
        Theory,
        InlineData(2012),
        InlineData(2010)
    ]
    public void YearProperty_FilledCar_FilledProperty(int year)
    {
        Car car = new Car("brand", "model", year, 100, "HP", 4);

        var result = car.Year;

        Assert.Equal(year, result);
    }

    [
        Theory,
        InlineData(100),
        InlineData(200)
    ]
    public void PowerProperty_FilledCar_FilledProperty(int power)
    {
        Car car = new Car("brand", "model", 2012, power, "HP", 4);

        var result = car.Power;

        Assert.Equal(power, result);
    }

    [
        Theory,
        InlineData("HP"),
        InlineData("CC")
    ]
    public void PowerUnitProperty_FilledCar_FilledProperty(string powerUnit)
    {
        Car car = new Car("brand", "model", 2012, 100, powerUnit, 4);

        var result = car.PowerUnit;

        Assert.Equal(powerUnit, result);
    }

    [
        Theory,
        InlineData(4),
        InlineData(2)
    ]
    public void DoorsProperty_FilledCar_FilledProperty(int doors)
    {
        Car car = new Car("brand", "model", 2012, 100, "HP", doors);

        var result = car.Doors;

        Assert.Equal(doors, result);
    }
}