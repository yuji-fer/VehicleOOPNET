// See https://aka.ms/new-console-template for more information
using VehicleOOPNETApp.src;

Car car = new Car("brand", "model", 2012, 100, "HP", 4);
Motorcycle motorcycle = new Motorcycle("brand", "model", 2012, 100, "HP");
Console.WriteLine(car);
Console.WriteLine(motorcycle.ToString(true));
