using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudioTools.Project;
using PowerShellTools.Interfaces;

namespace PowerShellTools.Project.PropertyPages
{
    [Guid(GuidList.AdvancedPropertiesPageGuid)]
    public class AdvancedPropertyPage : CommonPropertyPage
    {
        private readonly Control _advancedPropertyPage;
        private readonly IOptionsPane _pane;

        public AdvancedPropertyPage()
        {
            var componentModel = (IComponentModel)Package.GetGlobalService(typeof(SComponentModel));
            var x = componentModel.DefaultExportProvider.GetExports<IOptionsPane>("AdvancedOptionsPane").FirstOrDefault();
            if (x == null)
            {
                _advancedPropertyPage = new AdvanvedPropertyPageControl(this);
            }
            else
            {
                _pane = x.Value;
                _advancedPropertyPage = _pane.Control;
            }
        }

        public override Control Control
        {
            get { return _advancedPropertyPage; }
        }
        public override void Apply()
        {
            if (_pane == null) return;

            foreach (var item in _pane.Properties)
            {
                Project.SetProjectProperty(item.Key, item.Value);
            }
        }

        public override void LoadSettings()
        {
            if (_pane == null) return;

            Loading = true;
            foreach (var property in _pane.Properties)
            {
                _pane.Properties[property.Key] = Project.GetUnevaluatedProperty(property.Key);
            }
            Loading = false;
        }

        public override string Name
        {
            get { return "Advanced"; }
        }
    }
}
