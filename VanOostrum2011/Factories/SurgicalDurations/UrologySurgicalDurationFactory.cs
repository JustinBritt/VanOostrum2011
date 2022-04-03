namespace VanOostrum2011.Factories.SurgicalDurations
{
    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.SurgicalDurations;
    using VanOostrum2011.Records.SurgicalDurations;

    internal sealed class UrologySurgicalDurationFactory : IUrologySurgicalDurationFactory
    {
        public UrologySurgicalDurationFactory()
        {
        }

        public ISurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IUrologySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new UrologySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}