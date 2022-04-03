namespace VanOostrum2011.Factories.PatientLengthOfStays
{
    using VanOostrum2011.Interfaces.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.PatientLengthOfStays;
    using VanOostrum2011.Records.PatientLengthOfStays;

    internal sealed class OrthopedicSurgeryPatientLengthOfStayFactory : IOrthopedicSurgeryPatientLengthOfStayFactory
    {
        public OrthopedicSurgeryPatientLengthOfStayFactory()
        {
        }

        public IPatientLengthOfStay Create(
            IDurationFactory durationFactory)
        {
            IOrthopedicSurgeryPatientLengthOfStay patientLengthOfStay = null;

            try
            {
                patientLengthOfStay = new OrthopedicSurgeryPatientLengthOfStay(
                    durationFactory);
            }
            finally
            {
            }

            return patientLengthOfStay;
        }
    }
}