﻿namespace VanOostrum2011.Tests.Classes.Exports.PatientLengthOfStays
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using VanOostrum2011.AbstractFactories;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Exports.PatientLengthOfStays;

    [TestClass]
    public sealed class PatientLengthOfStayExport
    {
        private const string BoneAndMarrowTransplantationSurgery = "408476004";

        private const string day = "d";

        private const string skew = "skew";

        private const string SNOMEDCT = "http://snomed.info/sct";

        [TestMethod]
        public void EarNoseThroatSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 1.2m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EarNoseThroatSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 0.8m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EyeSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEyeSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 1.0m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EyeSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEyeSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 0.6m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GeneralSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGeneralSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 2.7m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GeneralSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGeneralSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 4.7m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GynecologyAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGynecology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 2.3m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GynecologyStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGynecology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 2.4m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OrthopedicSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOrthopedicSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 2.2m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OrthopedicSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOrthopedicSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 3.0m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OverallAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOverall(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 2.0m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OverallStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOverall(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 2.9m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void PlasticSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreatePlasticSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 1.6m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void PlasticSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreatePlasticSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 3.2m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void UrologyAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateUrology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 3.4m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
                actual: patientLengthOfStayOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void UrologyStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            IPatientLengthOfStayInputContext patientLengthOfStayInputContext = abstractFactory.CreateContextsAbstractFactory().CreatePatientLengthOfStayInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateUrology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            IPatientLengthOfStayExport patientLengthOfStayExport = abstractFactory.CreateExportsAbstractFactory().CreatePatientLengthOfStayExportFactory().Create();

            // Act
            IPatientLengthOfStayOutputContext patientLengthOfStayOutputContext = patientLengthOfStayExport.GetPatientLengthOfStay(
                abstractFactory,
                patientLengthOfStayInputContext);

            // Assert
            Assert.AreEqual(
                expected: 2.7m,
                actual: patientLengthOfStayOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: day,
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
    }
}