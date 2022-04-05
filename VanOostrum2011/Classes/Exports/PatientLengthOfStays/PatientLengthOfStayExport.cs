namespace VanOostrum2011.Classes.Exports.PatientLengthOfStays
{
    using VanOostrum2011.Extensions.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Exports.PatientLengthOfStays;
    using VanOostrum2011.InterfacesAbstractFactories;

    internal sealed class PatientLengthOfStayExport : IPatientLengthOfStayExport
    {
        public PatientLengthOfStayExport()
        {
        }

        public IPatientLengthOfStayOutputContext GetPatientLengthOfStay(
            IAbstractFactory abstractFactory,
            IPatientLengthOfStayInputContext patientLengthOfStayInputContext)
        {
            return abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayOutputContextFactory().Create(
                abstractFactory.CreatePatientLengthOfStaysAbstractFactory()
                .CreatePatientLengthOfStayFactory(
                    patientLengthOfStayInputContext.Specialty)
                .Create(
                    abstractFactory.CreateDependenciesAbstractFactory().CreateDurationFactory())
                .GetValue(
                    patientLengthOfStayInputContext.Statistic));
        }
    }
}