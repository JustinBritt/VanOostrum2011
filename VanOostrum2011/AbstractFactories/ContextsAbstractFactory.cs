namespace VanOostrum2011.AbstractFactories
{
    using VanOostrum2011.Factories.Contexts.PatientLengthOfStays;
    using VanOostrum2011.Factories.Contexts.SurgicalDurations;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.InterfacesFactories.Contexts.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Contexts.SurgicalDurations;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        public ContextsAbstractFactory()
        {
        }

        public IPatientLengthOfStayInputContextFactory CreatePatientLengthOfStayInputContextFactory()
        {
            IPatientLengthOfStayInputContextFactory factory = null;

            try
            {
                factory = new PatientLengthOfStayInputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IPatientLengthOfStayOutputContextFactory CreatePatientLengthOfStayOutputContextFactory()
        {
            IPatientLengthOfStayOutputContextFactory factory = null;

            try
            {
                factory = new PatientLengthOfStayOutputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalDurationInputContextFactory CreateSurgicalDurationInputContextFactory()
        {
            ISurgicalDurationInputContextFactory factory = null;

            try
            {
                factory = new SurgicalDurationInputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalDurationOutputContextFactory CreateSurgicalDurationOutputContextFactory()
        {
            ISurgicalDurationOutputContextFactory factory = null;

            try
            {
                factory = new SurgicalDurationOutputContextFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}