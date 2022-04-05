namespace VanOostrum2011.InterfacesAbstractFactories
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.InterfacesFactories.PatientLengthOfStays;

    public interface IPatientLengthOfStaysAbstractFactory
    {
        IEarNoseThroatSurgeryPatientLengthOfStayFactory CreateEarNoseThroatSurgeryPatientLengthOfStayFactory();

        IEyeSurgeryPatientLengthOfStayFactory CreateEyeSurgeryPatientLengthOfStayFactory();

        IGeneralSurgeryPatientLengthOfStayFactory CreateGeneralSurgeryPatientLengthOfStayFactory();

        IGynecologyPatientLengthOfStayFactory CreateGynecologyPatientLengthOfStayFactory();

        IOrthopedicSurgeryPatientLengthOfStayFactory CreateOrthopedicSurgeryPatientLengthOfStayFactory();

        IOverallPatientLengthOfStayFactory CreateOverallPatientLengthOfStayFactory();

        IPlasticSurgeryPatientLengthOfStayFactory CreatePlasticSurgeryPatientLengthOfStayFactory();

        IPatientLengthOfStayFactory CreatePatientLengthOfStayFactory(
            CodeableConcept specialty);

        IUrologyPatientLengthOfStayFactory CreateUrologyPatientLengthOfStayFactory();
    }
}