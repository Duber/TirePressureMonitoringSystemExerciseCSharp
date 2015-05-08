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
            var alarm = AlarmBuilder.AnAlarm().WithSensorDetecting(16).AndWithSafetyRangeBetween(17,21).Build();

            alarm.Check();

            Assert.AreEqual(true, alarm.IsOn);
        }

        [Test]
        public void AnAlarmIsOffWhenPressureIsSevenTeen()
        {
            var alarm = AlarmBuilder.AnAlarm().WithSensorDetecting(17).AndWithSafetyRangeBetween(17, 21).Build();

            alarm.Check();

            Assert.AreEqual(false, alarm.IsOn);
        }

        [Test]
        public void AnAlarmIsOnWhenPressureIsTweentyTwo()
        {
            var alarm = AlarmBuilder.AnAlarm().WithSensorDetecting(22).AndWithSafetyRangeBetween(17, 21).Build();

            alarm.Check();

            Assert.AreEqual(true, alarm.IsOn);
        }
    }
}
