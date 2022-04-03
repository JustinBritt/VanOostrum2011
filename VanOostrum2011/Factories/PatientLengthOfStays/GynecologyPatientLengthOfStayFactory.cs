namespace VanOostrum2011.Factories.PatientLengthOfStays
{
    using VanOostrum2011.Interfaces.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.PatientLengthOfStays;
    using VanOostrum2011.Records.PatientLengthOfStays;

    internal sealed class GynecologyPatientLengthOfStayFactory : IGynecologyPatientLengthOfStayFactory
    {
        public GynecologyPatientLengthOfStayFactory()
        {
        }

        public IPatientLengthOfStay Create(
            IDurationFactory durationFactory)
        {
            IGynecologyPatientLengthOfStay patientLengthOfStay = null;

            try
            {
                patientLengthOfStay = new GynecologyPatientLengthOfStay(
                    durationFactory);
            }
            finally
            {
            }

            return patientLengthOfStay;
        }
    }
}