namespace VanOostrum2011.Classes.Contexts.PatientLengthOfStays
{
    using Hl7.Fhir.Model;

    using VanOostrum2011.Interfaces.Contexts.PatientLengthOfStays;

    internal sealed class PatientLengthOfStayOutputContext : IPatientLengthOfStayOutputContext
    {
        public PatientLengthOfStayOutputContext(
            Duration duration)
        {
            this.Duration = duration;
        }

        public Duration Duration { get; }
    }
}