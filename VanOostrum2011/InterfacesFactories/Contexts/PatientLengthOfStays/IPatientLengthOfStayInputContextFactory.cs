namespace VanOostrum2011.InterfacesFactories.Contexts.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;

    public interface IPatientLengthOfStayInputContextFactory
    {
        IPatientLengthOfStayInputContext Create(
            CodeableConcept specialty,
            IValue<string> statistic);
    }
}