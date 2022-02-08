using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.NewRelicAgentForXamarin
{
    /// <summary>
    /// Interface for NewRelicAgentForXamarin
    /// </summary>
    public class NewRelicAgentForXamarinImplementation : INewRelicAgentForXamarin
    {

        var config = new NewRelicXamarin.Android.AgentConfiguration();
        config.ApplicationToken = "new_relic_license_key";
        NewRelicAgentForXamarin.Android.AndroidAgentImpl.Init(this, config);
        NewRelicAgentForXamarin.Android.Agent.Start();
    }
}
