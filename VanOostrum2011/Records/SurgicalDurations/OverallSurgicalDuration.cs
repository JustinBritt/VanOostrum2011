namespace VanOostrum2011.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;

    public sealed record OverallSurgicalDuration : IOverallSurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public OverallSurgicalDuration()
        {
            this.Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)47,
                Unit = minutes
            };

            this.StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)44.1,
                Unit = minutes
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}