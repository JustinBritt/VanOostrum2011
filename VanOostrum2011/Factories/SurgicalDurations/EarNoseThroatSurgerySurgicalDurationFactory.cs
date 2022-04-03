namespace VanOostrum2011.Factories.SurgicalDurations
{
    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.SurgicalDurations;
    using VanOostrum2011.Records.SurgicalDurations;

    internal sealed class EarNoseThroatSurgerySurgicalDurationFactory : IEarNoseThroatSurgerySurgicalDurationFactory
    {
        public EarNoseThroatSurgerySurgicalDurationFactory()
        {
        }

        public ISurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IEarNoseThroatSurgerySurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new EarNoseThroatSurgerySurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}