namespace VanOostrum2011.InterfacesAbstractFactories
{
    using VanOostrum2011.InterfacesFactories.Exports.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Exports.SurgicalDurations;

    public interface IExportsAbstractFactory
    {
        IPatientLengthOfStayExportFactory CreatePatientLengthOfStayExportFactory();

        ISurgicalDurationExportFactory CreateSurgicalDurationExportFactory();
    }
}