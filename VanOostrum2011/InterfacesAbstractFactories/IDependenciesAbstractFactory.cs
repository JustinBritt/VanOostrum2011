﻿namespace VanOostrum2011.InterfacesAbstractFactories
{
    using VanOostrum2011.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IDependenciesAbstractFactory
    {
        IDurationFactory CreateDurationFactory();
    }
}