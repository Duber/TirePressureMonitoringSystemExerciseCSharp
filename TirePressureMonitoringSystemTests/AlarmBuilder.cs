using System;
using System.Collections.Generic;
using System.Text;
using Moq;
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
            var sensorMock = new Mock<Sensor>();
            sensorMock.Setup(s => s.Measure()).Returns(measure);
            _sensor = sensorMock.Object;
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
