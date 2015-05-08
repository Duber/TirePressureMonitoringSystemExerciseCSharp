using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExercises.TirePressureMonitoringSystemTests
{
    [TestFixture]
    public class AlarmTest
    {
        public class FakeAlarm : Alarm
        {
            private double _pressure;
            public FakeAlarm(double pressure)
            {
                _pressure = pressure;
            }
            protected override double GetPressure()
            {
                return _pressure;
            }
        }

        [Test]
        public void SimpleTest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void AnAlarmIsOnWhenPressureIsSixteen()
        {
            var alarm = new FakeAlarm(16);

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
        }
    }
}
