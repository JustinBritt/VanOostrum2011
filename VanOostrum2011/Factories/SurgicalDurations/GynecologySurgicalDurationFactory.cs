namespace VanOostrum2011.Factories.SurgicalDurations
{
    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.SurgicalDurations;
    using VanOostrum2011.Records.SurgicalDurations;

    internal sealed class GynecologySurgicalDurationFactory : IGynecologySurgicalDurationFactory
    {
        public GynecologySurgicalDurationFactory()
        {
        }

        public ISurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IGynecologySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new GynecologySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}