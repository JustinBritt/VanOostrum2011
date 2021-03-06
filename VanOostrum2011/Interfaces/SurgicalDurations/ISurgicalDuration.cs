namespace VanOostrum2011.Interfaces.SurgicalDurations
{
    using Hl7.Fhir.Model;

    public interface ISurgicalDuration
    {
        Duration Mean { get; }

        Duration StandardDeviation { get; }
    }
}