using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HachiValidater.CheckConfigs
{
	public class Number : CheckComponent
	{
		public Number() : base() { }
		public Number(System.ComponentModel.IContainer container) : base(container) { }

		private Regex reg = new Regex(@"^\d+$");
		public override bool isConform(string targ)
		{
			return reg.IsMatch(targ);
		}
	}
}