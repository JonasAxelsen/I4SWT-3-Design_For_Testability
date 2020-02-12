using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Unit.Test
{
    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            throw new NotImplementedException();
        }
    }
}
