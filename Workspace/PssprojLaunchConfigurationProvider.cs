using System;
using System.IO;
using Microsoft.VisualStudio.Workspace;
using Microsoft.VisualStudio.Workspace.Debug;

namespace PowerShellTools.Workspace {
    [ExportLaunchConfigurationProvider(
        ProviderType,
        new[] { FileExtension },
        PssprojLaunchDebugTargetProvider.LaunchTypeName,
        PssprojLaunchDebugTargetProvider.JsonSchema
    )]
    class PssprojLaunchConfigurationProvider : ILaunchConfigurationProvider {
        public const string ProviderType = "fd922769-5725-41bc-b038-545a16995a68";

        private const string FileExtension = ".pssproj";

        public bool IsDebugLaunchActionSupported(DebugLaunchActionContext debugLaunchActionContext) {
            var settings = debugLaunchActionContext.LaunchConfiguration;
            var moniker = settings.GetValue(PssprojLaunchDebugTargetProvider.ProjectKey, string.Empty);
            if (string.IsNullOrEmpty(moniker) || !FileExtension.Equals(Path.GetExtension(moniker), StringComparison.OrdinalIgnoreCase)) {
                return false;
            }

            return true;
        }

        public void CustomizeLaunchConfiguration(DebugLaunchActionContext debugLaunchActionContext, IPropertySettings launchSettings) {
        }
    }
}
