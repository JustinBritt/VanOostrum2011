namespace VanOostrum2011.Interfaces.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    public interface IOrthopedicSurgeryPatientLengthOfStay
    {
        Duration Mean { get; }

        Duration StandardDeviation { get; }
    }
}