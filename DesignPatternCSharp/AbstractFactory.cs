using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp
{
    class Tyre
    {
        private string name;

        public Tyre(string name)
        {
            this.name = name;
        }
    }

    class SimpleTyre:Tyre
    {
        public SimpleTyre():base("Simple Tyre"){}
    }

    class LuxuryTyre:Tyre
    {
        public LuxuryTyre() : base("Luxury Tyre"){ }
    }

    class Body 
    {
        string name;
        public Body(string name)
        {
            this.name = name;
        }
    }
    class Car
    {
 
    }
    interface AbstractFactory
    {


    }
}
