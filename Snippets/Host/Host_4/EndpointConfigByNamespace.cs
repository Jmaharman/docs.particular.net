﻿#region EndpointNameByNamespace

namespace MyServer
{
    using NServiceBus;

    public class EndpointConfigByNamespace : IConfigureThisEndpoint, AsA_Server
    {
        // ... custom config

        #endregion
    }
}
