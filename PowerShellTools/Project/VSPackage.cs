namespace PowerShellTools.Project
{
	using System;
	using System.ComponentModel;
	using System.Runtime.InteropServices;
	using Microsoft.VisualStudio.Shell;

	/// <summary>
	/// This class implements the package exposed by this assembly.
	/// </summary>
	/// <remarks>
	/// This package is required if you want to define adds custom commands (ctmenu)
	/// or localized resources for the strings that appear in the New Project and Open Project dialogs.
	/// Creating project extensions or project types does not actually require a VSPackage.
	/// </remarks>
	[PackageRegistration(UseManagedResourcesOnly = true)]
	[Description("A custom project type based on CPS")]
	[Guid(VsPackage.PackageGuid)]
	public sealed class VsPackage : Package
	{
		/// <summary>
		/// The GUID for this package.
		/// </summary>
		public const string PackageGuid = "e6787023-7cb0-41f1-84b7-3e4472584cb1";

		/// <summary>
		/// The GUID for this project type.  It is unique with the project file extension and
		/// appears under the VS registry hive's Projects key.
		/// </summary>
		public const string ProjectTypeGuid = "1C4711F1-3766-4F84-9516-43FA4169CC36";

		/// <summary>
		/// The file extension of this project type.  No preceding period.
		/// </summary>
		public const string ProjectExtension = "psproj";

		/// <summary>
		/// The default namespace this project compiles with, so that manifest
		/// resource names can be calculated for embedded resources.
		/// </summary>
		internal const string DefaultNamespace = "PowerShell.Project";
	}
}