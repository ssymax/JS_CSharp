﻿using System.Collections.Generic;
using System.Linq;
using BasicCSharpConsole.Samples.Class;
using BasicCSharpConsole.Samples.Class.Inheritance;

namespace BasicCSharpConsole.Samples.Types
{
    class Anonymous
    {
        public static void Main()
        {
            var anonymousType = new {Value = 2};
            var value = anonymousType.Value;

            var cars = new List<Car>{new Car(3), new LuxurySportCar(), new Bulldozer()};
            var anonymousTypeCars = new {Cars = cars, cars.Count}; // default property name
           
            var areEqual = anonymousTypeCars.Cars.Count == anonymousTypeCars.Count; //properties are read-only

            var list = new [] {anonymousType, anonymousType}.ToList();
        }
    }
}
