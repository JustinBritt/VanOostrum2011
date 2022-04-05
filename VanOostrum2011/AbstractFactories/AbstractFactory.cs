namespace VanOostrum2011.AbstractFactories
{
    using VanOostrum2011.InterfacesAbstractFactories;

    public sealed class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory()
        {
        }

        public static IAbstractFactory Create()
        {
            return new AbstractFactory();
        }

        public IContextsAbstractFactory CreateContextsAbstractFactory()
        {
            IContextsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ContextsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IDependenciesAbstractFactory CreateDependenciesAbstractFactory()
        {
            IDependenciesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new DependenciesAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IExportsAbstractFactory CreateExportsAbstractFactory()
        {
            IExportsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ExportsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IPatientLengthOfStaysAbstractFactory CreatePatientLengthOfStaysAbstractFactory()
        {
            IPatientLengthOfStaysAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new PatientLengthOfStaysAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory()
        {
            ISurgicalDurationsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new SurgicalDurationsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }
    }
}