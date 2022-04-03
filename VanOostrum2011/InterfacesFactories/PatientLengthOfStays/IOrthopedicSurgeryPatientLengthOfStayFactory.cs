﻿namespace VanOostrum2011.InterfacesFactories.PatientLengthOfStays
{
    using VanOostrum2011.Interfaces.PatientLengthOfStays;
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IOrthopedicSurgeryPatientLengthOfStayFactory
    {
        IPatientLengthOfStay Create(
            IDurationFactory durationFactory);
    }
}