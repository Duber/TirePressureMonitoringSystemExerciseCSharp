namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        readonly Sensor _sensor;

        bool _isOn = false;

        public Alarm(Sensor sensor)
        {
            _sensor = sensor;
        }

        public void Check()
        {
            double measure = _sensor.Measure();

            if (measure < LowPressureThreshold || HighPressureThreshold < measure)
            {
                _isOn = true;
            }
        }

        public bool IsOn
        {
            get { return _isOn; }
        }

    }
}
