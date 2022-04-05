namespace VanOostrum2011.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        IContextsAbstractFactory CreateContextsAbstractFactory();

        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        IExportsAbstractFactory CreateExportsAbstractFactory();

        IPatientLengthOfStaysAbstractFactory CreatePatientLengthOfStaysAbstractFactory();

        ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory();
    }
}