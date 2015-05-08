using System;
using System.Collections.Generic;
using System.Text;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExercises.TirePressureMonitoringSystemTests
{
    public class PressureSensorMock : Sensor
    {
        private double _pressure;

        public PressureSensorMock(double pressure)
        {
            _pressure = pressure;
        }

        public double Measure()
        {
            return _pressure;
        }
    }
}
