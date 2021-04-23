namespace VanOostrum2011.Records.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.PatientLengthOfStays;

    public sealed record EyeSurgeryPatientLengthOfStay : IEyeSurgeryPatientLengthOfStay
    {
        private const string day = "d";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public EyeSurgeryPatientLengthOfStay()
        {
            this.Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)1.0,
                Unit = day
            };

            this.StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)0.6,
                Unit = day
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}