﻿namespace VanOostrum2011.InterfacesAbstractFactories
{
    public interface IAbstractFactory
    {
        IContextsAbstractFactory CreateContextsAbstractFactory();

        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        IPatientLengthOfStaysAbstractFactory CreatePatientLengthOfStaysAbstractFactory();

        ISurgicalDurationsAbstractFactory CreateSurgicalDurationsAbstractFactory();
    }
}