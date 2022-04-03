namespace VanOostrum2011.Interfaces.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    public interface ISurgicalDurationInputContext
    {
        CodeableConcept Specialty { get; }

        IValue<string> Statistic { get; }
    }
}