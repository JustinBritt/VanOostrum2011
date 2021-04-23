namespace VanOostrum2011.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;

    public sealed record PlasticSurgerySurgicalDuration : IPlasticSurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public PlasticSurgerySurgicalDuration()
        {
            this.Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)39,
                Unit = minutes
            };

            this.StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)25.3,
                Unit = minutes
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}