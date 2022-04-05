namespace VanOostrum2011.Factories.Exports.PatientLengthOfStays
{
    using VanOostrum2011.Classes.Exports.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Exports.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Exports.PatientLengthOfStays;

    internal sealed class PatientLengthOfStayExportFactory : IPatientLengthOfStayExportFactory
    {
        public PatientLengthOfStayExportFactory()
        {
        }

        public IPatientLengthOfStayExport Create()
        {
            IPatientLengthOfStayExport export = null;

            try
            {
                export = new PatientLengthOfStayExport();
            }
            finally
            {
            }

            return export;
        }
    }
}