using AM.Core.Domain;

Console.WriteLine("Hello, World!");
Plane p = new Plane();
p.Capacity = 1;
p.PlaneId = 1;
p.ManufactureDate = new DateTime(2025,11,02);
p.PlaneType = PlaneType.BOING;


Plane p2 = new Plane (PlaneType.BOING,365,new DateTime(2025,11,02));

//Object Initializer syntax
Plane p3 = new Plane
{
    Capacity = 200,
    PlaneId = 19,
    ManufactureDate = new DateTime(2020,05,15),
    PlaneType = PlaneType.AIRBUS
};

// Tester toutes les fonctionnalités 
Console.WriteLine(p);
Console.WriteLine(p2);
Console.WriteLine(p3);



