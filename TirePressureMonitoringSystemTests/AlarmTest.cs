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
        [Test]
        public void SimpleTest()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void AnAlarmIsOnWhenPressureIsSixTeen()
        {
            var alarm = new Alarm(new PressureSensorMock(16), new MeasureRange(17,21));

            alarm.Check();

            Assert.AreEqual(true, alarm.IsOn);
        }

        [Test]
        public void AnAlarmIsOffWhenPressureIsSevenTeen()
        {
            var alarm = new Alarm(new PressureSensorMock(17), new MeasureRange(17, 21));

            alarm.Check();

            Assert.AreEqual(false, alarm.IsOn);
        }

        [Test]
        public void AnAlarmIsOnWhenPressureIsTweentyTwo()
        {
            var alarm = new Alarm(new PressureSensorMock(22), new MeasureRange(17, 21));

            alarm.Check();

            Assert.AreEqual(true, alarm.IsOn);
        }
    }
}
