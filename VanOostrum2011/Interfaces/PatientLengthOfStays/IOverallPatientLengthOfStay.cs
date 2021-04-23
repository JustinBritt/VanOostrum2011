namespace VanOostrum2011.Interfaces.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    public interface IOverallPatientLengthOfStay
    {
        Duration Mean { get; }

        Duration StandardDeviation { get; }
    }
}