﻿using System;
using NServiceBus;
using NServiceBus.Transport.SqlServer;

class DelayedDelivery
{
    void Configure(EndpointConfiguration endpointConfiguration)
    {
        #region EnableNativeDelayedDelivery

        var transport = endpointConfiguration.UseTransport<SqlServerTransport>();
        var delayedDeliverySettings = transport.NativeDelayedDelivery();

        #endregion

        #region DelayedDeliveryTableSuffix

        delayedDeliverySettings.TableSuffix("Delayed");

        #endregion

        #region DelayedDeliveryProcessingInterval

        delayedDeliverySettings.ProcessingInterval(TimeSpan.FromSeconds(5));

        #endregion

        #region DelayedDeliveryBatchSize

        delayedDeliverySettings.BatchSize(100);

        #endregion

        #region DelayedDeliveryEnableTm

        delayedDeliverySettings.EnableTimeoutManagerCompatibility();

        #endregion
    }
}
