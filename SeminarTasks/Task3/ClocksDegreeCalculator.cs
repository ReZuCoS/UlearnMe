namespace SeminarTasks.Task3
{
    public static class ClocksDegreeCalculator
    {
        public static int DegreesFromHours(int hours)
        {
            if (hours < 0)
                throw new ArgumentOutOfRangeException($"\"{nameof(hours)}\" value must be in 0-24 range");

            int degrees = (hours * 30) - 360 * hours / 12;

            return Math.Abs(360 * (degrees / 180) - degrees);
        }
    }
}
