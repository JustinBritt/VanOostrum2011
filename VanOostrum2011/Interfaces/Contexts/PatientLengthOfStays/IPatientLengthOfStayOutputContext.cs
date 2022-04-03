namespace VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    public interface IPatientLengthOfStayOutputContext
    {
        Duration Duration { get; }
    }
}