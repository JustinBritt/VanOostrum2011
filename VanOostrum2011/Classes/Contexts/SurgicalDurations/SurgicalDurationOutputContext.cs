namespace VanOostrum2011.Classes.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;

    internal sealed class SurgicalDurationOutputContext : ISurgicalDurationOutputContext
    {
        public SurgicalDurationOutputContext(
            Duration duration)
        {
            this.Duration = duration;
        }

        public Duration Duration { get; }
    }
}