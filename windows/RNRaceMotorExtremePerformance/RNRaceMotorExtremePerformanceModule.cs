using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Race.Motor.Extreme.Performance.RNRaceMotorExtremePerformance
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRaceMotorExtremePerformanceModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRaceMotorExtremePerformanceModule"/>.
        /// </summary>
        internal RNRaceMotorExtremePerformanceModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRaceMotorExtremePerformance";
            }
        }
    }
}
