namespace VanOostrum2011.Tests.Classes.Exports.SurgicalDurations
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Hl7.Fhir.Model;

    using VanOostrum2011.AbstractFactories;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.Interfaces.Contexts.SurgicalDurations;
    using VanOostrum2011.Interfaces.Exports.SurgicalDurations;

    [TestClass]
    public sealed class SurgicalDurationExport
    {
        private const string minutes = "min";

        [TestMethod]
        public void EarNoseThroatSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 27m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EarNoseThroatSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 29.8m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EyeSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEyeSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 29m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void EyeSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateEyeSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 10.3m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GeneralSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGeneralSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 72m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GeneralSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGeneralSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 56.2m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GynecologyAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGynecology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 57m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void GynecologyStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateGynecology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 43.8m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OrthopedicSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOrthopedicSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 47m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OrthopedicSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOrthopedicSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 37.5m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OverallAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOverall(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 47m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void OverallStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateOverall(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 44.1m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void PlasticSurgeryAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreatePlasticSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 39m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void PlasticSurgeryStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreatePlasticSurgery(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 25.3m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void UrologyAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateUrology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateAverage());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 71m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void UrologyStdDev()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: dependenciesAbstractFactory.CreateCodeableConceptFactory().CreateUrology(),
                statistic: dependenciesAbstractFactory.CreateValueFactory().CreateStdDev());

            ISurgicalDurationExport surgicalDurationExport = abstractFactory.CreateExportsAbstractFactory().CreateSurgicalDurationExportFactory().Create();

            // Act
            ISurgicalDurationOutputContext surgicalDurationOutputContext = surgicalDurationExport.GetSurgicalDuration(
                abstractFactory,
                surgicalDurationInputContext);

            // Assert
            Assert.AreEqual(
                expected: 68.6m,
                actual: surgicalDurationOutputContext.Duration.Value.Value);

            Assert.AreEqual(
                expected: minutes,
                actual: surgicalDurationOutputContext.Duration.UnitElement.Value);
        }

        [TestMethod]
        public void InvalidSurgicalSpecialtyAverage()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            IDependenciesAbstractFactory dependenciesAbstractFactory = abstractFactory.CreateDependenciesAbstractFactory();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: new CodeableConcept("SCT", "invalid"),
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
    }
}