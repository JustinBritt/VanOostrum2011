namespace VanOostrum2011.Records.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record OverallSurgicalDuration : IOverallSurgicalDuration
    {
        private const string minutes = "min";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public OverallSurgicalDuration(
            IDurationFactory durationFactory)
        {
            this.Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 47m);

            this.StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: minutes,
                value: 44.1m);
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}