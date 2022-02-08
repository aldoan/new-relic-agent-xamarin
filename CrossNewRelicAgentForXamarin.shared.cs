using System;

namespace Plugin.NewRelicAgentForXamarin
{
    /// <summary>
    /// Cross NewRelicAgentForXamarin
    /// </summary>
    public static class CrossNewRelicAgentForXamarin
    {
        static Lazy<INewRelicAgentForXamarin> implementation = new Lazy<INewRelicAgentForXamarin>(() => CreateNewRelicAgentForXamarin(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => implementation.Value == null ? false : true;

        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static INewRelicAgentForXamarin Current
        {
            get
            {
                INewRelicAgentForXamarin ret = implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static INewRelicAgentForXamarin CreateNewRelicAgentForXamarin()
        {
#if NETSTANDARD1_0 || NETSTANDARD2_1
            return null;
#else
#pragma warning disable IDE0022 // Use expression body for methods
            return new NewRelicAgentForXamarinImplementation();
#pragma warning restore IDE0022 // Use expression body for methods
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

    }
}
