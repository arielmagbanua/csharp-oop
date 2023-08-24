// See https://aka.ms/new-console-template for more information
using CohesionAndCoupling.TightCoupling;

Console.WriteLine("Hello, World!");

PickupEngine pickupEngine = new PickupEngine();
TruckEngine truckEngine = new TruckEngine();
SUVEngine suvEngine = new SUVEngine();

// Car fortuner = new Car(truckEngine);
Car fortuner = new Car(suvEngine);

