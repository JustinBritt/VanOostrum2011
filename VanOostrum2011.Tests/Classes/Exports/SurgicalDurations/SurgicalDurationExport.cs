namespace VanOostrum2011.Tests.Classes.Exports.SurgicalDurations
{
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
        public void EarNoseThroatSurgerySurgicalDuration()
        {
            // Arrange
            IAbstractFactory abstractFactory = AbstractFactory.Create();

            ISurgicalDurationInputContext surgicalDurationInputContext = abstractFactory.CreateContextsAbstractFactory().CreateSurgicalDurationInputContextFactory().Create(
                specialty: abstractFactory.CreateDependenciesAbstractFactory().CreateCodeableConceptFactory().CreateEarNoseThroatSurgery(),
                statistic: abstractFactory.CreateDependenciesAbstractFactory().CreateValueFactory().CreateAverage());

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
    }
}