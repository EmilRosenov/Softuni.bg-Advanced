using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Car
    {
        
    //    List<Car> carList = new List<Car>();
    //    public List<Tire> Tires = new List<Tire>();

        public Car(string model, Engine engine, Cargo cargo,
            List<Tire> tires)
        {
            Model = model;
            Engine = engine;
            Cargo  = cargo;
            Tires = tires;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }
    }
    
    //•	Model: a string property
    //•	Engine: a class with two properties – speed and power,
    //•	Cargo: a class with two properties – type and weight 
    //•	Tires: a collection of exactly 4 tires.Each tire should have two properties: age and pressure.

}
