namespace VanOostrum2011.AbstractFactories
{
    using Hl7.Fhir.Model;

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

        public IEyeSurgeryPatientLengthOfStayFactory CreateEyeSurgeryPatientLengthOfStayFactory()
        {
            IEyeSurgeryPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new EyeSurgeryPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGeneralSurgeryPatientLengthOfStayFactory CreateGeneralSurgeryPatientLengthOfStayFactory()
        {
            IGeneralSurgeryPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new GeneralSurgeryPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGynecologyPatientLengthOfStayFactory CreateGynecologyPatientLengthOfStayFactory()
        {
            IGynecologyPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new GynecologyPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOrthopedicSurgeryPatientLengthOfStayFactory CreateOrthopedicSurgeryPatientLengthOfStayFactory()
        {
            IOrthopedicSurgeryPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new OrthopedicSurgeryPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOverallPatientLengthOfStayFactory CreateOverallPatientLengthOfStayFactory()
        {
            IOverallPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new OverallPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IPatientLengthOfStayFactory CreatePatientLengthOfStayFactory(
            CodeableConcept specialty)
        {
            IPatientLengthOfStayFactory factory = null;

            try
            {
                factory = specialty.Coding[0].Code switch
                {
                    EarNoseThroatSurgery => this.CreateEarNoseThroatSurgeryPatientLengthOfStayFactory(),

                    GeneralSurgery => this.CreateGeneralSurgeryPatientLengthOfStayFactory(),

                    GynecologicalSurgery => this.CreateGynecologyPatientLengthOfStayFactory(),

                    OphthalmicSurgery or Ophthalmology => this.CreateEyeSurgeryPatientLengthOfStayFactory(),

                    OrthopedicSurgery => this.CreateOrthopedicSurgeryPatientLengthOfStayFactory(),

                    Overall => this.CreateOverallPatientLengthOfStayFactory(),

                    PlasticSurgery => this.CreatePlasticSurgeryPatientLengthOfStayFactory(),

                    Urology => this.CreateUrologyPatientLengthOfStayFactory(),

                    _ => null
                };
            }
            finally
            {
            }

            return factory;
        }

        public IPlasticSurgeryPatientLengthOfStayFactory CreatePlasticSurgeryPatientLengthOfStayFactory()
        {
            IPlasticSurgeryPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new PlasticSurgeryPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IUrologyPatientLengthOfStayFactory CreateUrologyPatientLengthOfStayFactory()
        {
            IUrologyPatientLengthOfStayFactory factory = null;

            try
            {
                factory = new UrologyPatientLengthOfStayFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}