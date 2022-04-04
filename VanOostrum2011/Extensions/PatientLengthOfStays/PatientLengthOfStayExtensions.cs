namespace VanOostrum2011.Extensions.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.PatientLengthOfStays;

    public static class PatientLengthOfStayExtensions
    {
        private const string average = "average";
        private const string stddev = "std-dev";

        public static Duration GetValue(
            this IPatientLengthOfStay patientLengthOfStay,
            IValue<string> statistic)
        {
            return statistic.Value switch
            {
                average => patientLengthOfStay.Mean,

                stddev => patientLengthOfStay.StandardDeviation,

                _ => null
            };
        }
    }
}