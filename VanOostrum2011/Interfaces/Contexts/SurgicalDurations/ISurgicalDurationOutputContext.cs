namespace VanOostrum2011.Interfaces.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    public interface ISurgicalDurationOutputContext
    {
        Duration Duration { get; }
    }
}