namespace VanOostrum2011.Interfaces.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    public interface IPlasticSurgeryPatientLengthOfStay
    {
        Duration Mean { get; }

        Duration StandardDeviation { get; }
    }
}