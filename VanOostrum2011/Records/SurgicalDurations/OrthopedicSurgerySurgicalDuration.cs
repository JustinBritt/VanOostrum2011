namespace VanOostrum2011.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;

    public sealed record OrthopedicSurgerySurgicalDuration : IOrthopedicSurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public OrthopedicSurgerySurgicalDuration()
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
                Value = (decimal)37.5,
                Unit = minutes
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}