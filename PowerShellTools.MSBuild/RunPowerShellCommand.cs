using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Task = Microsoft.Build.Utilities.Task;

namespace PowerShellTools.MSBuild
{
    public class RunPowerShellCommand : Task
    {
        [Required]
        public ITaskItem Command { get; set; }
        
        public override bool Execute()
        {
            using (var ps = PowerShell.Create())
            {
                ps.AddScript(Command.ItemSpec);
                ps.Invoke();
            }

            return true;
        }
    }
}
