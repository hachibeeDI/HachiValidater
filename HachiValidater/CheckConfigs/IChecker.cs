using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HachiValidater.CheckConfigs
{
	public interface IChecker
	{
		bool isConform(string targ);
	}
}
