namespace VanOostrum2011.Classes.Contexts.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;

    internal sealed class PatientLengthOfStayInputContext : IPatientLengthOfStayInputContext
    {
        public PatientLengthOfStayInputContext(
            CodeableConcept specialty,
            IValue<string> statistic)
        {
            this.Specialty = specialty;

            this.Statistic = statistic;
        }

        public CodeableConcept Specialty { get; }

        public IValue<string> Statistic { get; }
    }
}