namespace VanOostrum2011.AbstractFactories
{
    using VanOostrum2011.Factories.Dependencies.Hl7.Fhir.R4.Model;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class DependenciesAbstractFactory : IDependenciesAbstractFactory
    {
        public DependenciesAbstractFactory()
        {
        }

        public IDurationFactory CreateDurationFactory()
        {
            IDurationFactory factory = null;

            try
            {
                factory = new DurationFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}