namespace VanOostrum2011.Factories.Contexts.SurgicalDurations
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Classes.Contexts.SurgicalDurations;
    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Contexts.SurgicalDurations;

    internal sealed class SurgicalDurationInputContextFactory : ISurgicalDurationInputContextFactory
    {
        public SurgicalDurationInputContextFactory()
        {
        }

        public ISurgicalDurationInputContext Create(
            CodeableConcept specialty,
            IValue<string> statistic)
        {
            ISurgicalDurationInputContext context = null;

            try
            {
                context = new SurgicalDurationInputContext(
                    specialty,
                    statistic);
            }
            finally
            {
            }

            return context;
        }
    }
}