﻿namespace VanOostrum2011.Factories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class CodeableConceptFactory : ICodeableConceptFactory
    {
        // Codes
        private const string EarNoseThroatSurgery = "394604002";
        private const string GeneralSurgery = "394609007";
        private const string GynecologicalSurgery = "394586005";
        private const string OphthalmicSurgery = "422191005";
        private const string Ophthalmology = "394594003";
        private const string OrthopedicSurgery = "24241000087106";
        private const string Overall = "394732004";
        private const string PlasticSurgery = "394611003";
        private const string Urology = "394612005";

        // System
        private const string SNOMEDCT = "http://snomed.info/sct";

        public CodeableConceptFactory()
        {
        }

        public CodeableConcept Create(
            string code,
            string system,
            string text = null)
        {
            CodeableConcept codeableConcept = null;

            try
            {
                codeableConcept = new CodeableConcept(
                    system: system,
                    code: code,
                    text: text);
            }
            finally
            {
            }

            return codeableConcept;
        }

        public CodeableConcept CreateEarNoseThroatSurgery()
        {
            return this.Create(
                code: EarNoseThroatSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateEyeSurgery()
        {
            return this.Create(
                code: OphthalmicSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateGeneralSurgery()
        {
            return this.Create(
                code: GeneralSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateGynecology()
        {
            return this.Create(
                code: GynecologicalSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateOrthopedicSurgery()
        {
            return this.Create(
                code: OrthopedicSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateOverall()
        {
            return this.Create(
                code: Overall,
                system: SNOMEDCT);
        }

        public CodeableConcept CreatePlasticSurgery()
        {
            return this.Create(
                code: PlasticSurgery,
                system: SNOMEDCT);
        }

        public CodeableConcept CreateUrology()
        {
            return this.Create(
                code: Urology,
                system: SNOMEDCT);
        }
    }
}