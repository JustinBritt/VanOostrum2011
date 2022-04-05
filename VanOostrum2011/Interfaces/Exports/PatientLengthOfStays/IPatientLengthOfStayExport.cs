namespace VanOostrum2011.Interfaces.Exports.PatientLengthOfStays
{
    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;
    using VanOostrum2011.InterfacesAbstractFactories;

    public interface IPatientLengthOfStayExport
    {
        IPatientLengthOfStayOutputContext GetPatientLengthOfStay(
            IAbstractFactory abstractFactory,
            IPatientLengthOfStayInputContext patientLengthOfStayInputContext);
    }
}