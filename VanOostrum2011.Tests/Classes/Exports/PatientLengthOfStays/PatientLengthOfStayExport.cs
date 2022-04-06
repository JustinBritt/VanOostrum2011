﻿namespace VanOostrum2011.Tests.Classes.Exports.PatientLengthOfStays
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Hl7.Fhir.Model;

    using VanOostrum2011.AbstractFactories;
    using VanOostrum2011.InterfacesAbstractFactories;
    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;
    using VanOostrum2011.Interfaces.Exports.PatientLengthOfStays;

    [TestClass]
    public sealed class PatientLengthOfStayExport
    {
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
        }
    }
}