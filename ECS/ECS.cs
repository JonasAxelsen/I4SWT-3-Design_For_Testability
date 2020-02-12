using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS
{
    public class ECS
    {
        private readonly IHeater _heater;
        private readonly ITempSensor _tempSensor;

        public ECS(int threshold, IHeater heater, ITempSensor tempSensor)
        {
            Threshold = threshold;
            _heater = heater;
            _tempSensor = tempSensor;
        }

        public ECS(IHeater heater, ITempSensor tempSensor)
        {
            Threshold = 15;
            _heater = heater;
            _tempSensor = tempSensor;
        }

        public int CurTemp { get { return _tempSensor.GetTemp(); } }
        public int Threshold { get; set; }

        public void Regulate()
        {
            if (CurTemp < Threshold) { _heater.TurnOn(); } 
            else { _heater.TurnOff(); }
        }
    }
}