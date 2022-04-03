namespace VanOostrum2011.InterfacesFactories.SurgicalDurations
{
    using VanOostrum2011.Interfaces.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IGeneralSurgerySurgicalDurationFactory
    {
        ISurgicalDuration Create(
            IDurationFactory durationFactory);
    }
}