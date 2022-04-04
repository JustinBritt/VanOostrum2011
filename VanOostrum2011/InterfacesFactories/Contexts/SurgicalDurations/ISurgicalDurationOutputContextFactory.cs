namespace VanOostrum2011.InterfacesFactories.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;

    public interface ISurgicalDurationOutputContextFactory
    {
        ISurgicalDurationOutputContext Create(
            Duration duration);
    }
}