namespace VanOostrum2011.Factories.PatientLengthOfStays
{
    using VanOostrum2011.Interfaces.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.PatientLengthOfStays;
    using VanOostrum2011.Records.PatientLengthOfStays;

    internal sealed class PlasticSurgeryPatientLengthOfStayFactory : IPlasticSurgeryPatientLengthOfStayFactory
    {
        public PlasticSurgeryPatientLengthOfStayFactory()
        {
        }

        public IPatientLengthOfStay Create(
            IDurationFactory durationFactory)
        {
            IPlasticSurgeryPatientLengthOfStay patientLengthOfStay = null;

            try
            {
                patientLengthOfStay = new PlasticSurgeryPatientLengthOfStay(
                    durationFactory);
            }
            finally
            {
            }

            return patientLengthOfStay;
        }
    }
}