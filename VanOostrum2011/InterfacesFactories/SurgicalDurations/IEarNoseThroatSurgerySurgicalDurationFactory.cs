namespace VanOostrum2011.InterfacesFactories.SurgicalDurations
{
    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IEarNoseThroatSurgerySurgicalDurationFactory
    {
        ISurgicalDuration Create(
            IDurationFactory durationFactory);
    }
}