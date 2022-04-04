namespace VanOostrum2011.Interfaces.Exports.SurgicalDurations
{
    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;
    using VanOostrum2011.Interfaces.Exports.SurgicalDurations;
    using VanOostrum2011.InterfacesAbstractFactories;

    public interface ISurgicalDurationExport
    {
        ISurgicalDurationOutputContext GetSurgicalDuration(
            IAbstractFactory abstractFactory,
            ISurgicalDurationInputContext surgicalDurationInputContext);
    }
}