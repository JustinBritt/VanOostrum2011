namespace VanOostrum2011.Records.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.PatientLengthOfStays;

    public sealed record GeneralSurgeryPatientLengthOfStay : IGeneralSurgeryPatientLengthOfStay
    {
        private const string day = "d";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public GeneralSurgeryPatientLengthOfStay()
        {
            this.Mean = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)2.7,
                Unit = day
            };

            this.StandardDeviation = new Duration()
            {
                System = unitsofmeasure,
                Value = (decimal)4.7,
                Unit = day
            };
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}