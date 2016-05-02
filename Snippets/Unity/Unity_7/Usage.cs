﻿using Microsoft.Practices.Unity;
using NServiceBus;

class Usage
{
    Usage(EndpointConfiguration endpointConfiguration)
    {
        #region Unity

        endpointConfiguration.UseContainer<UnityBuilder>();

        #endregion
    }

    void Existing(EndpointConfiguration endpointConfiguration)
    {
        #region Unity_Existing

        UnityContainer container = new UnityContainer();
        container.RegisterInstance(new MyService());
        endpointConfiguration.UseContainer<UnityBuilder>(c => c.UseExistingContainer(container));

        #endregion
    }

    class MyService
    {
    }
}