using System;
using System.IO;
using System.Linq;
using Microsoft.PythonTools.Infrastructure;
using Microsoft.PythonTools.Interpreter;
using Microsoft.PythonTools.Project;
using Microsoft.PythonTools.Project.Web;
using Microsoft.VisualStudio.Workspace;
using Microsoft.VisualStudio.Workspace.Debug;
using Microsoft.VisualStudioTools.Project;

namespace PowerShellTools.Workspace {
    [ExportLaunchDebugTarget(
        ProviderType,
        new[] { PowerShellConstants.FileExtension }
    )]
    class PythonLaunchDebugTargetProvider : ILaunchDebugTargetProvider {
        private const string ProviderType = "219820a8-5fa0-4627-afdb-cbf27ef1ffba";

        public const string LaunchTypeName = "powershell";

        // Set by the workspace, not by our users
        private const string ScriptNameKey = "target";

        public const string ScriptArgumentsKey = "scriptArguments";
        public const string WorkingDirectoryKey = "workingDirectory";

        public const string DefaultInterpreterValue = "(default)";

        public const string JsonSchema = @"{
  ""definitions"": {
    ""powershell"": {
      ""type"": ""object"",
      ""properties"": {
        ""type"": {""type"": ""string"", ""enum"": [ ""powershell"" ]},
        ""scriptArguments"": { ""type"": ""string"" },
        ""workingDirectory"": { ""type"": ""string"" }
      }
    },
    ""powershellFile"": {
      ""allOf"": [
        { ""$ref"": ""#/definitions/default"" },
        { ""$ref"": ""#/definitions/powershell"" }
      ]
    }
  },
    ""defaults"": {
        "".ps1"": { ""$ref"": ""#/definitions/powershell"" }
    },
    ""configuration"": ""#/definitions/powershellFile""
}";

        public void LaunchDebugTarget(IWorkspace workspace, IServiceProvider serviceProvider, DebugLaunchActionContext debugLaunchActionContext) {
            var registry = serviceProvider.GetComponentModel().GetService<IInterpreterRegistryService>();

            var settings = debugLaunchActionContext.LaunchConfiguration;
            var scriptName = settings.GetValue(ScriptNameKey, string.Empty);
            var debug = !settings.GetValue("noDebug", false);

            if (string.IsNullOrEmpty(scriptName)) {
                throw new InvalidOperationException(Strings.DebugLaunchScriptNameMissing);
            }

            /*
                TODO: Launch here!!

            IProjectLauncher launcher = null;
            var launchConfig = new LaunchConfiguration(config) {
                InterpreterPath = config == null ? path : null,
                InterpreterArguments = settings.GetValue(InterpreterArgumentsKey, string.Empty),
                ScriptName = scriptName,
                ScriptArguments = settings.GetValue(ScriptArgumentsKey, string.Empty),
                WorkingDirectory = settings.GetValue(WorkingDirectoryKey, string.Empty),
                // TODO: Support search paths
                SearchPaths = null,
                // TODO: Support env variables
                Environment = null,
            };
            launchConfig.LaunchOptions[PythonConstants.EnableNativeCodeDebugging] = settings.GetValue(NativeDebuggingKey, false).ToString();


            var browserUrl = settings.GetValue(WebBrowserUrlKey, string.Empty);
            if (!string.IsNullOrEmpty(browserUrl)) {
                launchConfig.LaunchOptions[PythonConstants.WebBrowserUrlSetting] = browserUrl;
                launcher = new PythonWebLauncher(serviceProvider, launchConfig, launchConfig, launchConfig);
            }

            (launcher ?? new DefaultPythonLauncher(serviceProvider, launchConfig)).LaunchProject(debug);
            
             */

        }

        public bool SupportsContext(IWorkspace workspace, string filePath) {
            throw new NotImplementedException();
        }
    }
}
