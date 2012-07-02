using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HachiValidater.CheckConfigs
{
	public interface IChecker<TControl>
		where TControl:System.Windows.Forms.Control
	{
		bool isConfirmed(TControl targ);
	}
}
