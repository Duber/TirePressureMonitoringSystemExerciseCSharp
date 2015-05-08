using System;
using System.Collections.Generic;
using System.Text;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExercises.TirePressureMonitoringSystemTests
{
    public class AlarmBuilder
    {
        private Sensor _sensor;
        private MeasureRange _range;

        public static AlarmBuilder AnAlarm()
        {
            return new AlarmBuilder();
        }

        public AlarmBuilder WithSensorDetecting(double measure)
        {
            _sensor = new PressureSensorMock(measure);
            return this;
        }

        public AlarmBuilder AndWithSafetyRangeBetween(double lowerLimit, double upperLimit)
        {
            _range = new MeasureRange(lowerLimit, upperLimit);
            return this;
        }

        public Alarm Build()
        {
            return new Alarm(_sensor, _range);
        }

    }
}
