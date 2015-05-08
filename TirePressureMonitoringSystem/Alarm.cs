namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        readonly Sensor _pressureSensor;

        bool _alarmOn = false;

        public Alarm()
        {
            _pressureSensor = new PressureSensor();
        }

        public Alarm(Sensor sensor)
        {
            _pressureSensor = sensor;
        }

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
