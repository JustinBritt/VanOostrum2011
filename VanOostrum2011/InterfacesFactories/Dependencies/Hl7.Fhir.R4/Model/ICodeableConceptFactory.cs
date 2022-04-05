namespace VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model
{
    using global::Hl7.Fhir.Model;

    public interface ICodeableConceptFactory
    {
        CodeableConcept Create(
            string code,
            string system,
            string text = null);

        CodeableConcept CreateEarNoseThroatSurgery();

        CodeableConcept CreateEyeSurgery();

        CodeableConcept CreateGeneralSurgery();

        CodeableConcept CreateGynecology();

        CodeableConcept CreateOrthopedicSurgery();

        CodeableConcept CreateOverall();

        CodeableConcept CreatePlasticSurgery();

        CodeableConcept CreateUrology();
    }
}