﻿namespace VanOostrum2011.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class ValueFactory : IValueFactory
    {
        private const string average = "average";
        private const string stddev = "std-dev";

        public ValueFactory()
        {
        }

        public IValue<string> Create(
            string value)
        {
            IValue<string> instance = null;

            try
            {
                instance = new FhirString(
                    value);
            }
            finally
            {
            }

            return instance;
        }

        public IValue<string> CreateAverage()
        {
            return this.Create(
                average);
        }

        public IValue<string> CreateStdDev()
        {
            return this.Create(
                stddev);
        }
    }
}