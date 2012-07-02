using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HachiValidater.CheckConfigs
{
	public class Omni:CheckConfigs.IChecker<System.Windows.Forms.TextBox>
	{
		private Regex reg;

		public Omni()
		{
		}

		public Omni(string re)
		{
			reg = new Regex(re);
		}

		public bool isConfirmed(System.Windows.Forms.TextBox targ)
		{
			if (targ.Text == "") { return true; } //donot requier check
			return reg.IsMatch(targ.Text);
		}
	}
}
