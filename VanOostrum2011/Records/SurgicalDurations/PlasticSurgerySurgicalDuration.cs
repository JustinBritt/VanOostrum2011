namespace VanOostrum2011.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record PlasticSurgerySurgicalDuration : IPlasticSurgerySurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public PlasticSurgerySurgicalDuration(
            IDurationFactory durationFactory)
        {
            this.Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 39m);

            this.StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 25.3m);
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}