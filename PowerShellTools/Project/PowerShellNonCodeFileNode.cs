using System;
using System.IO;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudioTools.Project;

namespace PowerShellTools.Project
{
    class PowerShellNonCodeFileNode : CommonNonCodeFileNode
    {
        private object _designerContext;

        public PowerShellNonCodeFileNode(CommonProjectNode root, ProjectElement e)
            : base(root, e)
        {
        }

        protected internal object DesignerContext
        {
            get
            {
                if (_designerContext == null)
                {
                    _designerContext = XamlDesignerSupport.CreateDesignerContext();
                    var child = ProjectMgr.FindNodeByFullPath(Url + PowerShellConstants.PS1File);
                    if (child != null)
                    {
                        XamlDesignerSupport.InitializeEventBindingProvider(_designerContext, child as PowerShellFileNode);
                    }
                }
                return _designerContext;
            }
        }
		
		public override int QueryService(ref Guid guidService, out object result)
        {
	        //
	        // If you have a code dom provider you'd provide it here.
	        if (guidService == typeof(SVSMDCodeDomProvider).GUID)
	        {
		        result = new PowerShellCodeDomProvider();
		        return VSConstants.S_OK;
	        }

			if (XamlDesignerSupport.DesignerContextType != null &&
                guidService == XamlDesignerSupport.DesignerContextType.GUID &&
                Path.GetExtension(Url).Equals(".xaml", StringComparison.OrdinalIgnoreCase))
            {
                // Create a DesignerContext for the XAML designer for this file
                result = DesignerContext;
                return VSConstants.S_OK;
            }

            return base.QueryService(ref guidService, out result);
        }
    }
    }
