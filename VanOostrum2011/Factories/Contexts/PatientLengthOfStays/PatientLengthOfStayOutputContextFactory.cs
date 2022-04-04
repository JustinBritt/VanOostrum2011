namespace VanOostrum2011.Factories.Contexts.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Classes.Contexts.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Contexts.PatientLengthOfStays;

    internal sealed class PatientLengthOfStayOutputContextFactory : IPatientLengthOfStayOutputContextFactory
    {
        public PatientLengthOfStayOutputContextFactory()
        {
        }

        public IPatientLengthOfStayOutputContext Create(
            Duration duration)
        {
            IPatientLengthOfStayOutputContext context = null;

            try
            {
                context = new PatientLengthOfStayOutputContext(
                    duration);
            }
            finally
            {
            }

            return context;
        }
    }
}