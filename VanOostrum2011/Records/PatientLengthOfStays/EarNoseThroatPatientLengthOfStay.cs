namespace VanOostrum2011.Records.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.PatientLengthOfStays;

    public sealed record EarNoseThroatPatientLengthOfStay : IEarNoseThroatPatientLengthOfStay
    {
        private const string day = "d";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public EarNoseThroatPatientLengthOfStay()
        {
            this.Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)1.2,
                Unit = day
            };

            this.StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)0.8,
                Unit = day
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}