namespace VanOostrum2011.Factories.Exports.SurgicalDurations
{
    using VanOostrum2011.Classes.Exports.SurgicalDurations;
    using VanOostrum2011.Interfaces.Exports.SurgicalDurations;
    using VanOostrum2011.InterfacesFactories.Exports.SurgicalDurations;

    internal sealed class SurgicalDurationExportFactory : ISurgicalDurationExportFactory
    {
        public SurgicalDurationExportFactory()
        {
        }

        public ISurgicalDurationExport Create()
        {
            ISurgicalDurationExport export = null;

            try
            {
                export = new SurgicalDurationExport();
            }
            finally
            {
            }

            return export;
        }
    }
}