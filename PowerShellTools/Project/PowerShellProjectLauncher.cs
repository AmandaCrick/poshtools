using EnvDTE80;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using PowerShellTools.Common.Logging;
using Microsoft.VisualStudio.ProjectSystem;
using Microsoft.VisualStudio.ProjectSystem.Debug;
using Microsoft.VisualStudio.ProjectSystem.VS.Debug;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.ProjectSystem.Properties;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PowerShellTools.Project
{
	/*
	[ExportDebugger(ScriptDebugger.SchemaName)]
	[AppliesTo(MyUnconfiguredProject.UniqueCapability)]
	internal class PowerShellProjectLauncher : IProjectLauncher
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(PowerShellProjectLauncher));
        private readonly PowerShellProjectNode _project;
        private readonly bool _dependenciesResolved;

        public PowerShellProjectLauncher(PowerShellProjectNode project, bool dependenciesResolved)
        {
            _dependenciesResolved = dependenciesResolved;
            _project = project;
        }


        public PowerShellProjectLauncher(bool dependenciesResolved)
            : this(null, dependenciesResolved)
        {
        }


        public int LaunchProject(bool debug)
        {
            string script = String.Empty;
            string startupFile = _project.GetStartupFile();

            if (startupFile != null)
            {
                script = startupFile;
            }
            else
            {
                var dte2 = (DTE2)Package.GetGlobalService(typeof(SDTE));
                if (dte2 != null)
                {
                    if (dte2.ActiveDocument != null)
                    {
                        script = dte2.ActiveDocument.FullName;
                    }
                }
            }

            if (!_dependenciesResolved) return VSConstants.E_NOTIMPL;

            Log.Debug("PowerShellProjectLauncher.LaunchProject");
            var debugger = (IVsDebugger)Package.GetGlobalService(typeof(IVsDebugger));
            var shell = (IVsUIShell)Package.GetGlobalService(typeof(IVsUIShell));

            var info = new VsDebugTargetInfo();
            info.cbSize = (uint)Marshal.SizeOf(info);
            info.dlo = DEBUG_LAUNCH_OPERATION.DLO_CreateProcess;
            info.bstrExe = script;
            info.bstrCurDir = Path.GetDirectoryName(info.bstrCurDir);

            try
            {
                info.bstrArg = _project.GetUnevaluatedProperty(ProjectConstants.DebugArguments);
            }
            catch
            {
                info.bstrArg = null;
            }

            info.bstrRemoteMachine = null; // debug locally
            info.fSendStdoutToOutputWindow = 0; // Let stdout stay with the application.
            info.clsidCustom = new Guid("{43ACAB74-8226-4920-B489-BFCF05372437}");
            // Set the launching engine the sample engine guid
            info.grfLaunch = 0;
            //info.clsidPortSupplier = new Guid("FEF0E138-4F86-467D-B5FB-46888D0D1A41");

            IntPtr pInfo = Marshal.AllocCoTaskMem((int)info.cbSize);
            Marshal.StructureToPtr(info, pInfo, false);

            var eventManager = new DebugEventManager(PowerShellToolsPackage.Debugger.Runspace);

            if (debugger.AdviseDebugEventCallback(eventManager) != VSConstants.S_OK)
            {
                Log.Debug("Failed to advise the UI of debug events.");
                if (pInfo != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(pInfo);
                }
            }

            try
            {
                debugger.LaunchDebugTargets(1, pInfo);
                string outstr;
                shell.GetErrorInfo(out outstr);

                if (!String.IsNullOrWhiteSpace(outstr))
                {
                    Log.Debug("Error:" + outstr);
                }
            }
            finally
            {
                if (pInfo != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(pInfo);
                }
            }

            return VSConstants.S_OK;
        }

        public int LaunchSelection(string selection)
        {
            if (!_dependenciesResolved) return VSConstants.E_NOTIMPL;

            if (PowerShellToolsPackage.Debugger == null)
            {
                MessageBox.Show(
                        Resources.PowerShellHostInitializingNotComplete,
                        Resources.MessageBoxErrorTitle,
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                return VSConstants.S_OK;
            }

            Log.Debug("PowerShellProjectLauncher.LaunchSelection");
            var debugger = (IVsDebugger)Package.GetGlobalService(typeof(IVsDebugger));
            var shell = (IVsUIShell)Package.GetGlobalService(typeof(IVsUIShell));

            var info = new VsDebugTargetInfo();
            info.cbSize = (uint)Marshal.SizeOf(info);
            info.dlo = DEBUG_LAUNCH_OPERATION.DLO_CreateProcess;

            info.bstrExe = "Selection";
            info.bstrCurDir = Environment.CurrentDirectory;
            info.bstrOptions = selection;
            info.bstrArg = null; // no command line parameters
            info.bstrRemoteMachine = null; // debug locally
            info.fSendStdoutToOutputWindow = 0; // Let stdout stay with the application.
            info.clsidCustom = new Guid("{43ACAB74-8226-4920-B489-BFCF05372437}");
            // Set the launching engine the sample engine guid
            info.grfLaunch = 0;
            //info.clsidPortSupplier = new Guid("FEF0E138-4F86-467D-B5FB-46888D0D1A41");

            IntPtr pInfo = Marshal.AllocCoTaskMem((int)info.cbSize);
            Marshal.StructureToPtr(info, pInfo, false);

            var eventManager = new DebugEventManager(PowerShellToolsPackage.Debugger.Runspace);

            if (debugger.AdviseDebugEventCallback(eventManager) != VSConstants.S_OK)
            {
                Log.Debug("Failed to advise the UI of debug events.");
                if (pInfo != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(pInfo);
                }
            }

            try
            {
                debugger.LaunchDebugTargets(1, pInfo);
                string outstr;
                shell.GetErrorInfo(out outstr);

                if (!String.IsNullOrWhiteSpace(outstr))
                {
                    Log.Debug("Error:" + outstr);
                }
            }
            finally
            {
                if (pInfo != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(pInfo);
                }
            }

            return VSConstants.S_OK;
        }

        public int LaunchFile(string file, bool debug, string args = null)
        {
            if (!_dependenciesResolved) return VSConstants.E_NOTIMPL;

            if (PowerShellToolsPackage.Debugger == null)
            {
                MessageBox.Show(
                           Resources.PowerShellHostInitializingNotComplete,
                           Resources.MessageBoxErrorTitle,
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);

                return VSConstants.S_OK;
            }

            Log.Debug("PowerShellProjectLauncher.LaunchFile");
            var debugger = (IVsDebugger)Package.GetGlobalService(typeof(IVsDebugger));
            var shell = (IVsUIShell)Package.GetGlobalService(typeof(IVsUIShell));

            var info = new VsDebugTargetInfo();
            if (args != null)
            {
                info.bstrArg = args;
            }
            
            info.cbSize = (uint)Marshal.SizeOf(info);
            info.dlo = DEBUG_LAUNCH_OPERATION.DLO_CreateProcess;

            info.bstrExe = file;
            info.bstrCurDir = Path.GetDirectoryName(info.bstrExe);

            if (_project != null)
            {
                try
                {
                    info.bstrArg = _project.GetUnevaluatedProperty(ProjectConstants.DebugArguments);
                }
                catch
                {
                    info.bstrArg = null;
                }
            }

            info.bstrRemoteMachine = null; // debug locally
            info.fSendStdoutToOutputWindow = 0; // Let stdout stay with the application.
            info.clsidCustom = new Guid("{43ACAB74-8226-4920-B489-BFCF05372437}");
            // Set the launching engine the sample engine guid
            info.grfLaunch = 0;
            //info.clsidPortSupplier = new Guid("FEF0E138-4F86-467D-B5FB-46888D0D1A41");

            IntPtr pInfo = Marshal.AllocCoTaskMem((int)info.cbSize);
            Marshal.StructureToPtr(info, pInfo, false);

            var eventManager = new DebugEventManager(PowerShellToolsPackage.Debugger.Runspace);

            if (debugger.AdviseDebugEventCallback(eventManager) != VSConstants.S_OK)
            {
                Log.Debug("Failed to advise the UI of debug events.");
                if (pInfo != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(pInfo);
                }
            }

            try
            {
                debugger.LaunchDebugTargets(1, pInfo);
                string outstr;
                shell.GetErrorInfo(out outstr);

                if (!String.IsNullOrWhiteSpace(outstr))
                {
                    Log.Debug("Error:" + outstr);
                }
            }
            finally
            {
                if (pInfo != IntPtr.Zero)
                {
                    Marshal.FreeCoTaskMem(pInfo);
                }
            }

            return VSConstants.S_OK;
        }
    }
	*/
	[ExportDebugger("PowerShellScriptDebugger")]
	[AppliesTo(MyUnconfiguredProject.UniqueCapability)]
	public class ScriptDebuggerLaunchProvider : DebugLaunchProviderBase
	{
		[ImportingConstructor]
		public ScriptDebuggerLaunchProvider(ConfiguredProject configuredProject)
			: base(configuredProject)
		{
		}

		[ExportPropertyXamlRuleDefinition("PowerShellTools, Version=1.2.3.4, Culture=neutral, PublicKeyToken=9be6e469bc4921f1", "XamlRuleToCode:PowerShellScriptDebugger.xaml", "Project")]
		[AppliesTo(MyUnconfiguredProject.UniqueCapability)]
		private object DebuggerXaml { get { throw new NotImplementedException(); } }

		/// <summary>
		/// Gets project properties that the debugger needs to launch.
		/// </summary>
		[Import]
		private ProjectProperties ProjectProperties { get; set; }

		public override async Task<bool> CanLaunchAsync(DebugLaunchOptions launchOptions)
		{
			await System.Threading.Tasks.Task.FromResult(0);
			return true;
		}

		public override async Task<IReadOnlyList<IDebugLaunchSettings>> QueryDebugTargetsAsync(DebugLaunchOptions launchOptions)
		{
			await System.Threading.Tasks.Task.FromResult(0);

			string script = String.Empty;
			var settings = new DebugLaunchSettings(launchOptions);

			var dte2 = (DTE2)Package.GetGlobalService(typeof(SDTE));
			if (dte2 != null)
			{
				if (dte2.ActiveDocument != null)
				{
					script = dte2.ActiveDocument.FullName;
				}
			}

			//settings.Arguments = string.Format("\"{0}\" //X {1}", startupItem, cmdArguments);
			settings.LaunchOperation = DebugLaunchOperation.CreateProcess;
			settings.LaunchDebugEngineGuid = new Guid("{43ACAB74-8226-4920-B489-BFCF05372437}");
			settings.Executable = script;

			return new IDebugLaunchSettings[] { settings };
		}
	}
}
