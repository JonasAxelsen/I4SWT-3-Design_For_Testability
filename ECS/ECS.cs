using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS
{
    public class ECS
    {
        private IHeater _heater;
        private ITempSensor _tempSensor;

        ECS(IHeater heater, ITempSensor tempSensor)
        {
            _heater = heater;
            _tempSensor = tempSensor
        }

        public int CurTemp
        {
            get { return _tempSensor.GetTemp(); }
        }

        public int Threshold { get; set; }

        public void Regulate()
        {
            throw new System.NotImplementedException();
        }
    }
}