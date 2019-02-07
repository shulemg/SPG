//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Services;
using DevExpress.XtraScheduler;

namespace SuperiorPackGroup
{
	public class CustomMouseHandlerService : MouseHandlerServiceWrapper
	{
		private IServiceProvider provider;

		public CustomMouseHandlerService(IServiceProvider provider, IMouseHandlerService service) : base(service)
		{

			this.provider = provider;
		}

		public override void OnMouseWheel(MouseEventArgs e)
		{

			SchedulerControl scheduler = provider as SchedulerControl;
			if (scheduler != null && scheduler.ActiveViewType == SchedulerViewType.Timeline)
			{
				return;
			}

			base.OnMouseWheel(e);

		}

	}

}