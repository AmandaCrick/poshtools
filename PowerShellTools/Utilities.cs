using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace PowerShellTools
{
	internal class MyUtilities
	{
		public static bool SaveDirtyFiles()
		{
			var rdt = ServiceProvider.GlobalProvider.GetService(typeof(SVsRunningDocumentTable)) as IVsRunningDocumentTable;
			if (rdt != null)
			{
				// Consider using (uint)(__VSRDTSAVEOPTIONS.RDTSAVEOPT_SaveIfDirty | __VSRDTSAVEOPTIONS.RDTSAVEOPT_PromptSave)
				// when VS settings include prompt for save on build
				var saveOpt = (uint)__VSRDTSAVEOPTIONS.RDTSAVEOPT_SaveIfDirty;
				var hr = rdt.SaveDocuments(saveOpt, null, VSConstants.VSITEMID_NIL, VSConstants.VSCOOKIE_NIL);
				if (hr == VSConstants.E_ABORT)
				{
					return false;
				}
			}

			return true;
		}
	}
}
