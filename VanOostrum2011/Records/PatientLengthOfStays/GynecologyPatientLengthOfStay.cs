namespace VanOostrum2011.Records.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record GynecologyPatientLengthOfStay : IGynecologyPatientLengthOfStay
    {
        private const string day = "d";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public GynecologyPatientLengthOfStay(
            IDurationFactory durationFactory)
        {
            this.Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: day,
                value: 2.3m);

            this.StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: day,
                value: 2.4m);
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}