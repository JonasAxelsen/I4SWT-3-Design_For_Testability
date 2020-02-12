using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS
{
    public interface ITempSensor
    {
        int GetTemp();
    }

    public class TempSensor : ITempSensor
    {
        Random rng = new Random();
        public int GetTemp()
        {
            return rng.Next(-4, 20);
        }
    }
}