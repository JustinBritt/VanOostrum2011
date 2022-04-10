namespace VanOostrum2011.Tests.Classes.Exports.SurgicalDurations
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanOostrum2011.AbstractFactories;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;
    using VanOostrum2011.Interfaces.Exports.SurgicalDurations;

    [TestClass]
    public sealed class SurgicalDurationExport
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string Neurosurgery = "394610002";
        private const string OphthalmicSurgery = "422191005";
        private const string Ophthalmology = "394594003";
        private const string OrthopedicSurgery = "24241000087106";
        private const string Overall = "394732004";
        private const string PlasticSurgery = "394611003";
        private const string Trauma = "394801008";
        private const string Urology = "394612005";

        private const string BoneAndMarrowTransplantationSurgery = "408476004";

        private const string minutes = "min";

        private const string skew = "skew";

        private const string SNOMEDCT = "http://snomed.info/sct";

        private const string average = "average";
        private const string stddev = "std-dev";

        private static IEnumerable<object[]> Table1Data =>
            new[]
            {
                new object[] { EarNoseThroatSurgery, 27m, minutes, average },

                new object[] { EarNoseThroatSurgery, 29.8m, minutes, stddev },

                new object[] { Ophthalmology, 29m, minutes, average },

                new object[] { Ophthalmology, 10.3m, minutes, stddev },

                new object[] { GeneralSurgery, 72m, minutes, average },

                new object[] { GeneralSurgery, 56.2m, minutes, stddev },

                new object[] { GynecologicalSurgery, 57m, minutes, average },

                new object[] { GynecologicalSurgery, 43.8m, minutes, stddev },

                new object[] { OrthopedicSurgery, 47m, minutes, average },

                new object[] { OrthopedicSurgery, 37.5m, minutes, stddev },

                new object[] { Overall, 47m, minutes, average },

                new object[] { Overall, 44.1m, minutes, stddev },

                new object[] { PlasticSurgery, 39m, minutes, average },

                new object[] { PlasticSurgery, 25.3m, minutes, stddev },

                new object[] { Urology, 71m, minutes, average },

                new object[] { Urology, 68.6m, minutes, stddev },
            };

        [TestMethod]
        [DynamicData(nameof(Table1Data))]
        public void Table1(
            string specialty,
            decimal value,
            string unit,
            string statistic)
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(specialty, SNOMEDCT, null),
                statistic: dependenciesAbstractFactory.CreateValueFactory().Create(statistic));

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EarNoseThroatSurgeryInvalidStatistic()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().Create(skew));

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.IsNull(
                surgicalDurationOutputContext.Duration);
        }

        [TestMethod]
        public void InvalidSurgicalSpecialtyAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(BoneAndMarrowTransplantationSurgery, SNOMEDCT, null),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            Action action = () =>
            {
                ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                    abstractFactory,
                    surgicalDurationInputContext);
            };

            // Assert
            Assert.ThrowsException<NullReferenceException>(
                action);
        }

        [TestMethod]
        public void InvalidSurgicalSpecialtyStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(BoneAndMarrowTransplantationSurgery, SNOMEDCT, null),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            Action action = () =>
            {
                ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                    abstractFactory,
                    surgicalDurationInputContext);
            };

            // Assert
            Assert.ThrowsException<NullReferenceException>(
                action);
        }
    }
}