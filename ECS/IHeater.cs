using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS
{
    public interface IHeater
    {
        void TurnOn();
        void TurnOff();
    }

    public class Heater : IHeater
    {
        public void TurnOn()
        {
            Console.WriteLine("Heater turned on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Heater turned off!");
        }
    }
}