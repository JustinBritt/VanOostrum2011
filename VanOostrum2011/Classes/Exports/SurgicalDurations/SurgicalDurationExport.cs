namespace VanOostrum2011.Classes.Exports.SurgicalDurations
{
    using VanOostrum2011.Extensions.SurgicalDurations;
    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;
    using VanOostrum2011.Interfaces.Exports.SurgicalDurations;
    using VanOostrum2011.InterfacesAbstractFactories;

    internal sealed class SurgicalDurationExport : ISurgicalDurationExport
    {
        public SurgicalDurationExport()
        {
        }

        public ISurgicalDurationOutputContext GetSurgicalDuration(
            IAbstractFactory abstractFactory,
            ISurgicalDurationInputContext surgicalDurationInputContext)
        {
            return abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationOutputContextFactory().Create(
                abstractFactory.CreateSurgicalDurationsAbstractFactory()
                .CreateSurgicalDurationFactory(
                    surgicalDurationInputContext.Specialty)
                .Create(
                    abstractFactory.CreateDependenciesAbstractFactory().CreateDurationFactory())
                .GetValue(
                    surgicalDurationInputContext.Statistic));
        }
    }
}