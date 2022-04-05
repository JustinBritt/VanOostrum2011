namespace VanOostrum2011.AbstractFactories
{
    using VanOostrum2011.Factories.Exports.PatientLengthOfStays;
    using VanOostrum2011.Factories.Exports.SurgicalDurations;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.InterfacesFactories.Exports.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Exports.SurgicalDurations;
    
    internal sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        public ExportsAbstractFactory()
        {
        }

        public IPatientLengthOfStayExportFactory CreatePatientLengthOfStayExportFactory()
        {
            IPatientLengthOfStayExportFactory factory = null;

            try
            {
                factory = new PatientLengthOfStayExportFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalDurationExportFactory CreateSurgicalDurationExportFactory()
        {
            ISurgicalDurationExportFactory factory = null;

            try
            {
                factory = new SurgicalDurationExportFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}