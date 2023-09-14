using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DesignPatterns.Creational
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Car : Prototype
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public  List<string>  Options { get; set; }

        public Car(string make, string model, int year, List<string> options)
        {
            Make = make;
            Model = model;
            Year = year;
            Options = options;
        }

        public override Prototype Clone()
        {
            return new Car(Make, Model, Year, new List<string> (Options));
        }
    }

}
