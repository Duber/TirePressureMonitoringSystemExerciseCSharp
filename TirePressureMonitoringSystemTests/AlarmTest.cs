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
        public void AnAlarmIsOnWhenPressureIsSixTeen()
        {
            var alarm = new FakeAlarm(16);

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
        }

        [Test]
        public void AnAlarmIsOffWhenPressureIsSevenTeen()
        {
            var alarm = new FakeAlarm(17);

            alarm.Check();

            Assert.AreEqual(false, alarm.AlarmOn);
        }

        [Test]
        public void AnAlarmIsOnWhenPressureIsTweentyTwo()
        {
            var alarm = new FakeAlarm(22);

            alarm.Check();

            Assert.AreEqual(true, alarm.AlarmOn);
        }
    }
}
