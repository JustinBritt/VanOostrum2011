namespace VanOostrum2011.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;

    public sealed record GynecologySurgicalDuration : IGynecologySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public GynecologySurgicalDuration()
        {
            this.Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)57,
                Unit = minutes
            };

            this.StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)43.8,
                Unit = minutes
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}