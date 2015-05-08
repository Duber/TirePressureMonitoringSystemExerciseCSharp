namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private readonly Sensor _sensor;
        private readonly MeasureRange _range;

        bool _isOn = false;

        public Alarm(Sensor sensor, MeasureRange range)
        {
            _sensor = sensor;
            _range = range;
        }

        public void Check()
        {
            double measure = _sensor.Measure();
            _isOn = _range.IsNotSafe(measure);
        }

        public bool IsOn
        {
            get { return _isOn; }
        }

    }
}
