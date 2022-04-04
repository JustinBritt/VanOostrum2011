namespace VanOostrum2011.AbstractFactories
{
    using VanOostrum2011.Factories.PatientLengthOfStays;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.InterfacesFactories.PatientLengthOfStays;

    internal sealed class PatientLengthOfStaysAbstractFactory : IPatientLengthOfStaysAbstractFactory
    {
        public PatientLengthOfStaysAbstractFactory()
        {
        }

        public IEarNoseThroatSurgeryPatientLengthOfStayFactory CreateEarNoseThroatSurgeryPatientLengthOfStayFactory()
        {
            IEarNoseThroatSurgeryPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new EarNoseThroatSurgeryPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}