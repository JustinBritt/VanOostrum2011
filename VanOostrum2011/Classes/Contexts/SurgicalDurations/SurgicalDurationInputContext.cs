namespace VanOostrum2011.Classes.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;

    internal sealed class SurgicalDurationInputContext : ISurgicalDurationInputContext
    {
        public SurgicalDurationInputContext(
            CodeableConcept specialty,
            IValue<string> statistic)
        {
            this.Specialty = specialty;

            this.Statistic = statistic;
        }

        public CodeableConcept Specialty { get; }

        public IValue<string> Statistic { get; }
    }
}