namespace VanOostrum2011.Factories.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Classes.Contexts.SurgicalDurations;
    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Contexts.SurgicalDurations;

    internal sealed class SurgicalDurationOutputContextFactory : ISurgicalDurationOutputContextFactory
    {
        public SurgicalDurationOutputContextFactory()
        {
        }

        public ISurgicalDurationOutputContext Create(
            Duration duration)
        {
            ISurgicalDurationOutputContext context = null;

            try
            {
                context = new SurgicalDurationOutputContext(
                    duration);
            }
            finally
            {
            }

            return context;
        }
    }
}