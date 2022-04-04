namespace VanOostrum2011.Extensions.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;

    public static class SurgicalDurationExtensions
    {
        private const string average = "average";
        private const string stddev = "std-dev";

        public static Duration GetValue(
            this ISurgicalDuration surgicalDuration,
            IValue<string> statistic)
        {
            return statistic.Value switch
            {
                average => surgicalDuration.Mean,

                stddev => surgicalDuration.StandardDeviation,

                _ => null
            };
        }
    }
}