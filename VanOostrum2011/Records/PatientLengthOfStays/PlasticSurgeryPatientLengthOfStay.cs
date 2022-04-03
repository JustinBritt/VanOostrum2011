﻿namespace VanOostrum2011.Records.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public sealed record PlasticSurgeryPatientLengthOfStay : IPlasticSurgeryPatientLengthOfStay
    {
        private const string day = "d";
        private const string unitsofmeasure = "http://unitsofmeasure.org";

        public PlasticSurgeryPatientLengthOfStay(
            IDurationFactory durationFactory)
        {
            this.Mean = durationFactory.Create(
                system: unitsofmeasure,
                unit: day,
                value: 1.6m);

            this.StandardDeviation = durationFactory.Create(
                system: unitsofmeasure,
                unit: day,
                value: 3.2m);
        }

        public Duration Mean { get; }

        public Duration StandardDeviation { get; }
    }
}