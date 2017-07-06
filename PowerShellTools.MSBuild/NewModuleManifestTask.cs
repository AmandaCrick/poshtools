using System;
using System.Management.Automation.Runspaces;
using System.Text;
using Microsoft.Build.Framework;
using Task = Microsoft.Build.Utilities.Task;

namespace PowerShellTools.MSBuild
{

    public class NewModuleManifestTask : Task
    {
        [Required]
        public ITaskItem Path { get; set; }
        public ITaskItem NestedModules { get; set; }
        public ITaskItem Guid { get; set; }
        public ITaskItem Author { get; set; }
        public ITaskItem CompanyName { get; set; }
        public ITaskItem Copyright { get; set; }
        public ITaskItem RootModule { get; set; }
        public ITaskItem ModuleVersion { get; set; }
        public ITaskItem Description { get; set; }
        public ITaskItem ProcessorArchitecture { get; set; }
        public ITaskItem PowerShellVersion { get; set; }
        public ITaskItem ClrVersion { get; set; }
        public ITaskItem DotNetFrameworkVersion { get; set; }
        public ITaskItem PowerShellHostName { get; set; }
        public ITaskItem PowerShellHostVersion { get; set; }
        public ITaskItem RequiredModules { get; set; }
        public ITaskItem TypesToProcess { get; set; }
        public ITaskItem FormatsToProcess { get; set; }
        public ITaskItem ScriptsToProcess { get; set; }
        public ITaskItem RequiredAssemblies { get; set; }
        public ITaskItem FileList { get; set; }
        public ITaskItem ModuleList { get; set; }
        public ITaskItem FunctionsToExport { get; set; }
        public ITaskItem AliasesToExport { get; set; }
        public ITaskItem VariablesToExport { get; set; }
        public ITaskItem CmdletsToExport { get; set; }
        public ITaskItem DscResourcesToExport { get; set; }
        public ITaskItem CompatiblePSEditions { get; set; }
        public ITaskItem PrivateData { get; set; }
        public ITaskItem Tags { get; set; }
        public ITaskItem ProjectUri { get; set; }
        public ITaskItem LicenseUri { get; set; }
        public ITaskItem IconUri { get; set; }
        public ITaskItem ReleaseNotes { get; set; }
        public ITaskItem HelpInfoUri { get; set; }
        public ITaskItem DefaultCommandPrefix { get; set; }

        public override bool Execute()
        {
            var host = new MSBuildPowerShellHost(s =>
            {
                if (!string.IsNullOrEmpty(s))
                    this.Log.LogMessage(MessageImportance.High, s);
            });

            var command = new StringBuilder();
            command.AppendLine("$commandArgs = @{");

            if (Path != null) command.AppendLine(string.Format("Path = {0};", Path.ItemSpec));
            if (NestedModules != null) command.AppendLine(string.Format("NestedModules = {0};", NestedModules.ItemSpec));
            if (Guid != null) command.AppendLine(string.Format("Guid = {0};", Guid.ItemSpec));
            if (Author != null) command.AppendLine(string.Format("Author = {0};", Author.ItemSpec));
            if (CompanyName != null) command.AppendLine(string.Format("CompanyName = {0};", CompanyName.ItemSpec));
            if (Copyright != null) command.AppendLine(string.Format("Copyright = {0};", Copyright.ItemSpec));
            if (RootModule != null) command.AppendLine(string.Format("RootModule = {0};", RootModule.ItemSpec));
            if (ModuleVersion != null) command.AppendLine(string.Format("ModuleVersion = {0};", ModuleVersion.ItemSpec));
            if (Description != null) command.AppendLine(string.Format("Description = {0};", Description.ItemSpec));
            if (ProcessorArchitecture != null) command.AppendLine(string.Format("ProcessorArchitecture = {0};", ProcessorArchitecture.ItemSpec));
            if (PowerShellVersion != null) command.AppendLine(string.Format("PowerShellVersion = {0};", PowerShellVersion.ItemSpec));
            if (ClrVersion != null) command.AppendLine(string.Format("ClrVersion = {0};", ClrVersion.ItemSpec));
            if (DotNetFrameworkVersion != null) command.AppendLine(string.Format("DotNetFrameworkVersion = {0};", DotNetFrameworkVersion.ItemSpec));
            if (PowerShellHostName != null) command.AppendLine(string.Format("PowerShellHostName = {0};", PowerShellHostName.ItemSpec));
            if (PowerShellHostVersion != null) command.AppendLine(string.Format("PowerShellHostVersion = {0};", PowerShellHostVersion.ItemSpec));
            if (RequiredModules != null) command.AppendLine(string.Format("RequiredModules = {0};", RequiredModules.ItemSpec));
            if (TypesToProcess != null) command.AppendLine(string.Format("TypesToProcess = {0};", TypesToProcess.ItemSpec));
            if (FormatsToProcess != null) command.AppendLine(string.Format("FormatsToProcess = {0};", FormatsToProcess.ItemSpec));
            if (ScriptsToProcess != null) command.AppendLine(string.Format("ScriptsToProcess = {0};", ScriptsToProcess.ItemSpec));
            if (RequiredAssemblies != null) command.AppendLine(string.Format("RequiredAssemblies = {0};", RequiredAssemblies.ItemSpec));
            if (FileList != null) command.AppendLine(string.Format("FileList = {0};", FileList.ItemSpec));
            if (ModuleList != null) command.AppendLine(string.Format("ModuleList = {0};", ModuleList.ItemSpec));
            if (FunctionsToExport != null) command.AppendLine(string.Format("FunctionsToExport = {0};", FunctionsToExport.ItemSpec));
            if (AliasesToExport != null) command.AppendLine(string.Format("AliasesToExport = {0};", AliasesToExport.ItemSpec));
            if (VariablesToExport != null) command.AppendLine(string.Format("VariablesToExport = {0};", VariablesToExport.ItemSpec));
            if (CmdletsToExport != null) command.AppendLine(string.Format("CmdletsToExport = {0};", CmdletsToExport.ItemSpec));
            if (DscResourcesToExport != null) command.AppendLine(string.Format("DscResourcesToExport = {0};", DscResourcesToExport.ItemSpec));
            if (CompatiblePSEditions != null) command.AppendLine(string.Format("CompatiblePSEditions = {0};", CompatiblePSEditions.ItemSpec));
            if (PrivateData != null) command.AppendLine(string.Format("PrivateData = {0};", PrivateData.ItemSpec));
            if (Tags != null) command.AppendLine(string.Format("Tags = {0};", Tags.ItemSpec));
            if (ProjectUri != null) command.AppendLine(string.Format("ProjectUri = {0};", ProjectUri.ItemSpec));
            if (LicenseUri != null) command.AppendLine(string.Format("LicenseUri = {0};", LicenseUri.ItemSpec));
            if (IconUri != null) command.AppendLine(string.Format("IconUri = {0};", IconUri.ItemSpec));
            if (ReleaseNotes != null) command.AppendLine(string.Format("ReleaseNotes = {0};", ReleaseNotes.ItemSpec));
            if (HelpInfoUri != null) command.AppendLine(string.Format("HelpInfoUri = {0};", HelpInfoUri.ItemSpec));
            if (DefaultCommandPrefix != null) command.AppendLine(string.Format("DefaultCommandPrefix = {0};", DefaultCommandPrefix.ItemSpec));
            command.AppendLine("}");
            command.AppendLine("New-ModuleManifest @commandArgs");

            try
            {
                var runspace = RunspaceFactory.CreateRunspace(host);
                runspace.Open();
                
                var pipe = runspace.CreatePipeline();
                pipe.Commands.Add(command.ToString());
                pipe.Commands.Add("out-default");
                pipe.Commands[0].MergeMyResults(PipelineResultTypes.Error, PipelineResultTypes.Output);
                pipe.Invoke();
            }
            catch (Exception ex)
            {
                this.Log.LogErrorFromException(ex);
                return false;
            }

            return true;
        }
    }
}
