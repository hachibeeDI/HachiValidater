using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HachiValidater.CheckConfigs
{
	public class ValidateContainer<TControl>
		where TControl:System.Windows.Forms.Control
	{

		public List<TControl> controls { get; set; }

		public IChecker<TControl> checker { get; set; }

		public string message { get; set; }


		public ValidateContainer(IChecker<TControl> _checker, string _message)
		{
			checker = _checker; message = _message;
		}


		public List<TControl> areConfirm()
		{
			// return Controls that isnot confirmed
			return controls.FindAll(con => (!checker.isConfirmed(con)));
		}
		
	}
}

