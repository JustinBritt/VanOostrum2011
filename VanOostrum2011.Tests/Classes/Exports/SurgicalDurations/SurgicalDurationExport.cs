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
    public class SurgicalDurationExport
    {
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