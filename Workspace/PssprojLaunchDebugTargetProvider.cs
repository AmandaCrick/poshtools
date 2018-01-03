using System;
using System.IO;
using System.Linq;
using Microsoft.PythonTools.Infrastructure;
using Microsoft.PythonTools.Interpreter;
using Microsoft.PythonTools.Project;
using Microsoft.PythonTools.Project.Web;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Workspace;
using Microsoft.VisualStudio.Workspace.Debug;
using Microsoft.VisualStudioTools.Project;

namespace PowerShellTools.Workspace {
    [ExportLaunchDebugTarget(
        ProviderType,
        new[] { ".pssproj" }
    )]
    class PssprojLaunchDebugTargetProvider : ILaunchDebugTargetProvider {
        private const string ProviderType = "13eba676-9d51-4122-b4c6-1ee7d57d3cb8";

        public const string LaunchTypeName = "pssproj";

        // Set by the workspace, not by our users
        internal const string ProjectKey = "target";

        public const string JsonSchema = @"{
  ""definitions"": {
    ""pssproj"": {
      ""type"": ""object"",
      ""properties"": {
        ""type"": {""type"": ""string"", ""enum"": [ ""pssproj"" ]}
      }
    },
    ""pssprojFile"": {
      ""allOf"": [
        { ""$ref"": ""#/definitions/default"" },
        { ""$ref"": ""#/definitions/pssproj"" }
      ]
    }
  },
    ""defaults"": {
        "".pssproj"": { ""$ref"": ""#/definitions/pssproj"" }
    },
    ""configuration"": ""#/definitions/pssprojFile""
}";

        public void LaunchDebugTarget(IWorkspace workspace, IServiceProvider serviceProvider, DebugLaunchActionContext debugLaunchActionContext) {
            var settings = debugLaunchActionContext.LaunchConfiguration;
            var moniker = settings.GetValue(ProjectKey, string.Empty);
            if (string.IsNullOrEmpty(moniker)) {
                throw new InvalidOperationException();
            }

            var solution = serviceProvider.GetService(typeof(SVsSolution)) as IVsSolution;
            var solution4 = solution as IVsSolution4;
            var debugger = serviceProvider.GetShellDebugger();

            if (solution == null || solution4 == null) {
                throw new InvalidOperationException();
            }

            solution4.EnsureSolutionIsLoaded(0);
            var proj = solution.EnumerateLoadedPythonProjects()
                .FirstOrDefault(p => string.Equals(p.GetMkDocument(), moniker, StringComparison.OrdinalIgnoreCase));

            if (proj == null) {
                throw new InvalidOperationException();
            }

            ErrorHandler.ThrowOnFailure(proj.GetLauncher().LaunchProject(true));
        }

        public bool SupportsContext(IWorkspace workspace, string filePath) {
            throw new NotImplementedException();
        }
    }
}
