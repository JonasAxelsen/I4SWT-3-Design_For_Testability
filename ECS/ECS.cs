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

        ECS(int threshold, IHeater heater, ITempSensor tempSensor)
        {
            Threshold = threshold;
            _heater = heater;
            _tempSensor = tempSensor;
        }

        public int CurTemp
        {
            get { return _tempSensor.GetTemp(); }
        }

        public int Threshold { get; set; }

        public void Regulate()
        {
            if (CurTemp < Threshold) { _heater.TurnOn(); } 
            else { _heater.TurnOff(); }
        }
    }
}