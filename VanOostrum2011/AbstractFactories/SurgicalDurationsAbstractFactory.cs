namespace VanOostrum2011.AbstractFactories
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Factories.SurgicalDurations;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.InterfacesFactories.SurgicalDurations;

    internal sealed class SurgicalDurationsAbstractFactory : ISurgicalDurationsAbstractFactory
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string OphthalmicSurgery = "422191005";
        private const string Ophthalmology = "394594003";
        private const string OrthopedicSurgery = "24241000087106";
        private const string PlasticSurgery = "394611003";
        private const string Urology = "394612005";

        public SurgicalDurationsAbstractFactory()
        {
        }

        public IEarNoseThroatSurgerySurgicalDurationFactory CreateEarNoseThroatSurgerySurgicalDurationFactory()
        {
            IEarNoseThroatSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new EarNoseThroatSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IEyeSurgerySurgicalDurationFactory CreateEyeSurgerySurgicalDurationFactory()
        {
            IEyeSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new EyeSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGeneralSurgerySurgicalDurationFactory CreateGeneralSurgerySurgicalDurationFactory()
        {
            IGeneralSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new GeneralSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGynecologySurgicalDurationFactory CreateGynecologySurgicalDurationFactory()
        {
            IGynecologySurgicalDurationFactory factory = null;

            try
            {
                factory = new GynecologySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IOrthopedicSurgerySurgicalDurationFactory CreateOrthopedicSurgerySurgicalDurationFactory()
        {
            IOrthopedicSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new OrthopedicSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IPlasticSurgerySurgicalDurationFactory CreatePlasticSurgerySurgicalDurationFactory()
        {
            IPlasticSurgerySurgicalDurationFactory factory = null;

            try
            {
                factory = new PlasticSurgerySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISurgicalDurationFactory CreateSurgicalDurationFactory(
            CodeableConcept specialty)
        {
            ISurgicalDurationFactory factory = null;

            try
            {
                factory = specialty.Coding[0].Code switch
                {
                    EarNoseThroatSurgery => this.CreateEarNoseThroatSurgerySurgicalDurationFactory(),

                    GeneralSurgery => this.CreateGeneralSurgerySurgicalDurationFactory(),

                    GynecologicalSurgery => this.CreateGynecologySurgicalDurationFactory(),

                    OphthalmicSurgery or Ophthalmology => this.CreateEyeSurgerySurgicalDurationFactory(),

                    OrthopedicSurgery => this.CreateOrthopedicSurgerySurgicalDurationFactory(),

                    PlasticSurgery => this.CreatePlasticSurgerySurgicalDurationFactory(),

                    Urology => this.CreateUrologySurgicalDurationFactory(),

                    _ => null
                };
            }
            finally
            {
            }

            return factory;
        }

        public IUrologySurgicalDurationFactory CreateUrologySurgicalDurationFactory()
        {
            IUrologySurgicalDurationFactory factory = null;

            try
            {
                factory = new UrologySurgicalDurationFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}