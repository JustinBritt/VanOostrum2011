namespace VanOostrum2011.InterfacesAbstractFactories
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.InterfacesFactories.SurgicalDurations;

    public interface ISurgicalDurationsAbstractFactory
    {
        IEarNoseThroatSurgerySurgicalDurationFactory CreateEarNoseThroatSurgerySurgicalDurationFactory();

        IEyeSurgerySurgicalDurationFactory CreateEyeSurgerySurgicalDurationFactory();

        IGeneralSurgerySurgicalDurationFactory CreateGeneralSurgerySurgicalDurationFactory();

        IGynecologySurgicalDurationFactory CreateGynecologySurgicalDurationFactory();

        IOrthopedicSurgerySurgicalDurationFactory CreateOrthopedicSurgerySurgicalDurationFactory();

        IOverallSurgicalDurationFactory CreateOverallSurgicalDurationFactory();

        IPlasticSurgerySurgicalDurationFactory CreatePlasticSurgerySurgicalDurationFactory();

        ISurgicalDurationFactory CreateSurgicalDurationFactory(
            CodeableConcept specialty);

        IUrologySurgicalDurationFactory CreateUrologySurgicalDurationFactory();
    }
}