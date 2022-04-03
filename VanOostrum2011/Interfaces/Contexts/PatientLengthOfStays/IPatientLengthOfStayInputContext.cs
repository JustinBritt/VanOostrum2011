namespace VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    public interface IPatientLengthOfStayInputContext
    {
        CodeableConcept Specialty { get; }

        IValue<string> Statistic { get; }
    }
}