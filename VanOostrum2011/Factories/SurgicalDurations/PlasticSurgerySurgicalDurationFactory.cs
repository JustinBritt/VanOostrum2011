namespace VanOostrum2011.Factories.SurgicalDurations
{
    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.SurgicalDurations;
    using VanOostrum2011.Records.SurgicalDurations;

    internal sealed class PlasticSurgerySurgicalDurationFactory : IPlasticSurgerySurgicalDurationFactory
    {
        public PlasticSurgerySurgicalDurationFactory()
        {
        }

        public ISurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IPlasticSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new PlasticSurgerySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}