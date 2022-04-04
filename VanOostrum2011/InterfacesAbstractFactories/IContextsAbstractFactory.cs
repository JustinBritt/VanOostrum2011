namespace VanOostrum2011.InterfacesAbstractFactories
{
    using VanOostrum2011.InterfacesFactories.Contexts.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Contexts.SurgicalDurations;

    public interface IContextsAbstractFactory
    {
        IPatientLengthOfStayInputContextFactory CreatePatientLengthOfStayInputContextFactory();

        IPatientLengthOfStayOutputContextFactory CreatePatientLengthOfStayOutputContextFactory();

        ISurgicalDurationInputContextFactory CreateSurgicalDurationInputContextFactory();

        ISurgicalDurationOutputContextFactory CreateSurgicalDurationOutputContextFactory();
    }
}