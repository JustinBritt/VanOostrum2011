namespace VanOostrum2011.Factories.Contexts.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Classes.Contexts.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Contexts.PatientLengthOfStays;

    internal sealed class PatientLengthOfStayInputContextFactory : IPatientLengthOfStayInputContextFactory
    {
        public PatientLengthOfStayInputContextFactory()
        {
        }

        public IPatientLengthOfStayInputContext Create(
            CodeableConcept specialty,
            IValue<string> statistic)
        {
            IPatientLengthOfStayInputContext context = null;

            try
            {
                context = new PatientLengthOfStayInputContext(
                    specialty,
                    statistic);
            }
            finally
            {
            }

            return context;
        }
    }
}