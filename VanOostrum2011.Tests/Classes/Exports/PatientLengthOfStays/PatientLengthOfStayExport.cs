namespace VanOostrum2011.Tests.Classes.Exports.PatientLengthOfStays
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanOostrum2011.AbstractFactories;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Exports.PatientLengthOfStays;

    [TestClass]
    public sealed class PatientLengthOfStayExport
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string Ophthalmology = "394594003";
        private const string OrthopedicSurgery = "24241000087106";
        private const string Overall = "394732004";
        private const string PlasticSurgery = "394611003";
        private const string Urology = "394612005";

        private const string BoneAndMarrowTransplantationSurgery = "408476004";

        private const string day = "d";

        private const string skew = "skew";

        private const string SNOMEDCT = "http://snomed.info/sct";

        private const string average = "average";
        private const string stddev = "std-dev";

        private static IEnumerable<object[]> Table1Data =>
            new[]
            {
                new object[] { EarNoseThroatSurgery, 1.2m, day, average },

                new object[] { EarNoseThroatSurgery, 0.8m, day, stddev },

                new object[] { Ophthalmology, 1.0m, day, average },

                new object[] { Ophthalmology, 0.6m, day, stddev },

                new object[] { GeneralSurgery, 2.7m, day, average },

                new object[] { GeneralSurgery, 4.7m, day, stddev },

                new object[] { GynecologicalSurgery, 2.3m, day, average },

                new object[] { GynecologicalSurgery, 2.4m, day, stddev },

                new object[] { OrthopedicSurgery, 2.2m, day, average },

                new object[] { OrthopedicSurgery, 3.0m, day, stddev },

                new object[] { Overall, 2.0m, day, average },

                new object[] { Overall, 2.9m, day, stddev },

                new object[] { PlasticSurgery, 1.6m, day, average },

                new object[] { PlasticSurgery, 3.2m, day, stddev },

                new object[] { Urology, 3.4m, day, average },

                new object[] { Urology, 2.7m, day, stddev },
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

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(specialty, SNOMEDCT, null),
                statistic: dependenciesAbstractFactory.CreateValueFactory().Create(statistic));

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: value,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: unit,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EarNoseThroatSurgeryInvalidStatistic()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().Create(skew));

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.IsNull(
                patientLengthOfStayOutputContext.Duration);
        }

        [TestMethod]
        public void InvalidSurgicalSpecialtyAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(BoneAndMarrowTransplantationSurgery, SNOMEDCT, null),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            Action action = () =>
            {
                IPatientLengthOfStayOutputContext surgicalDurationOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                    abstractFactory,
                    patientLengthOfStayInputContext);
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

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().Create(BoneAndMarrowTransplantationSurgery, SNOMEDCT, null),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            Action action = () =>
            {
                IPatientLengthOfStayOutputContext surgicalDurationOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                    abstractFactory,
                    patientLengthOfStayInputContext);
            };

            // Assert
            Assert.ThrowsException<NullReferenceException>(
                action);
        }
    }
}