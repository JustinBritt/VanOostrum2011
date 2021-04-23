namespace VanOostrum2011.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;

    public sealed record GeneralSurgerySurgicalDuration : IGeneralSurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public GeneralSurgerySurgicalDuration()
        {
            this.Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)72,
                Unit = minutes
            };

            this.StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)56.2,
                Unit = minutes
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}