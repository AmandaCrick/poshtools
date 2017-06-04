using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudioTools.Project;

namespace PowerShellTools.Project.PropertyPages
{
    [Guid(GuidList.BuildEventsPropertiesPageGuid)]
    public class BuildEventPropertyPage : CommonPropertyPage
    {
        private readonly BuildEventPropertyPageControl _control;

        public BuildEventPropertyPage()
        {
            _control = new BuildEventPropertyPageControl(this);
        }

        public override Control Control
        {
            get { return _control; }
        }
        public override void Apply()
        {
            Project.SetProjectProperty("BuildEventExecutionPolicy", _control.ExecutionPolicy);
            Project.SetProjectProperty("PreBuild", _control.Prebuild);
            Project.SetProjectProperty("PostBuild", _control.Postbuild);
            IsDirty = false;
        }

        public override void LoadSettings()
        {
            _control.LoadingSettings = true;
            _control.ExecutionPolicy = Project.GetProjectProperty("BuildEventExecutionPolicy", false);
            _control.Prebuild = Project.GetProjectProperty("Prebuild", false);
            _control.Postbuild = Project.GetProjectProperty("Postbuild", false);
            _control.LoadingSettings = false;
        }

        public override string Name
        {
            get { return "Build Events"; }
        }
    }
}
