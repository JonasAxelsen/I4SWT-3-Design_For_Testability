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
        public int GetTemp()
        {
            throw new NotImplementedException();
        }
    }

    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            throw new NotImplementedException();
        }
    }
}