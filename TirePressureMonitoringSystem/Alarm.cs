namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        readonly PressureSensor _pressureSensor = new PressureSensor();

        bool _alarmOn = false;

        public void Check()
        {
            double psiPressureValue = GetPressure();

            if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;
            }
        }

        protected virtual double GetPressure()
        {
            return _pressureSensor.PopNextPressurePsiValue();
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
