namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        readonly Sensor _sensor;

        bool _alarmOn = false;

        public Alarm(Sensor sensor)
        {
            _sensor = sensor;
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
            return _sensor.PopNextPressurePsiValue();
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
