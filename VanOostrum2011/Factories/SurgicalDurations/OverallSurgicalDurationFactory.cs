namespace VanOostrum2011.Factories.SurgicalDurations
{
    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesFactories.SurgicalDurations;
    using VanOostrum2011.Records.SurgicalDurations;

    internal sealed class OverallSurgicalDurationFactory : IOverallSurgicalDurationFactory
    {
        public OverallSurgicalDurationFactory()
        {
        }

        public ISurgicalDuration Create(
            IDurationFactory durationFactory)
        {
            IOverallSurgicalDuration surgicalDuration = null;

            try
            {
                surgicalDuration = new OverallSurgicalDuration(
                    durationFactory);
            }
            finally
            {
            }

            return surgicalDuration;
        }
    }
}