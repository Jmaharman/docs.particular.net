﻿using System;
using ServiceControl.Plugin.CustomChecks;

class CustomChecks
{
    #region CustomCheck5
    public class MyCustomCheck : CustomCheck
    {
        public MyCustomCheck()
            : base("SomeId-StartUp", "SomeCategory")
        {
            if (SomeService.GetStatus())
            {
                ReportPass();
            }
            else
            {
                ReportFailed("Some service is not available.");
            }
        }
    }
    #endregion

    #region PeriodicCheck5
    public class MyPeriodicCheck : PeriodicCheck
    {
        public MyPeriodicCheck()
            : base("SomeId-Periodic", "SomeCategory", TimeSpan.FromSeconds(5))
        {
        }

        public override CheckResult PerformCheck()
        {
            if (SomeService.GetStatus())
            {
                return CheckResult.Pass;
            }
            else
            {
                return CheckResult.Failed("Some service is not available.");
            }
        }
    }
    #endregion

    public class SomeService
    {
        public static bool GetStatus()
        {
            return false;
        }
    }

}