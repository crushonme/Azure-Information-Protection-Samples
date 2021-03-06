﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.microsoft.rightsmanagement.mobile.viewer.lib;

namespace com.microsoft.rightsmanagement.windows.viewer
{
	internal class PermissionsMenuItem : IMenuItem
	{
		public bool IsEnabled { get; set; }
		public Icon Icon { get; } = ServicesUtils.GetService<IconServiceWindows>().GetIcon(Icon.IconType.Permission);
		public string Description { get; }
		public void Click()
		{
			throw new NotImplementedException();
		}
	}
}
