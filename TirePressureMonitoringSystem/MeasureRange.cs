namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class MeasureRange
    {
        private double _lowerLimit;
        private double _upperLimit;

        public MeasureRange(double lowerLimit, double upperLimit)
        {
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
        }

        public bool IsNotSafe(double measure)
        {
            if (measure < _lowerLimit || _upperLimit < measure)
            {
                return true;
            }
            return false;
        }
    }
}