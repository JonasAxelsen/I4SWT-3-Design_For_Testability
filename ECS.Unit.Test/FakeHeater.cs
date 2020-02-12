using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Unit.Test
{
    public class FakeHeater : IHeater
    {
        public bool IsCalledOn { get; private set; } = false;
        public bool IsCalledOff { get; private set; } = false;

        public void TurnOn()
        {
            IsCalledOn = true;
        }

        public void TurnOff()
        {
            IsCalledOff = true;
        }
    }
}
