using System;
using Microsoft.VisualStudio.Imaging.Interop;

namespace PowerShellTools.Project
{
	public static class IconsMonikers
	{
		private static readonly Guid ManifestGuid = new Guid("bd4da623-bc03-4465-b5f9-95565a3f66b6");

		private const int ProjectIcon = 0;

		public static ImageMoniker ProjectIconImageMoniker
		{
			get
			{
				return new ImageMoniker { Guid = ManifestGuid, Id = ProjectIcon };
			}
		}
	}
}
