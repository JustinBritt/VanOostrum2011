namespace VanOostrum2011.AbstractFactories
{
    using VanOostrum2011.Factories.PatientLengthOfStays;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.InterfacesFactories.PatientLengthOfStays;

    internal sealed class PatientLengthOfStaysAbstractFactory : IPatientLengthOfStaysAbstractFactory
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string OphthalmicSurgery = "422191005";
        private const string Ophthalmology = "394594003";
        private const string OrthopedicSurgery = "24241000087106";
        private const string Overall = "394732004";
        private const string PlasticSurgery = "394611003";
        private const string Urology = "394612005";

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