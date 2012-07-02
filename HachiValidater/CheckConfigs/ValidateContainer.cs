using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HachiValidater.CheckConfigs
{
	public class ValidateContainer
	{
		
		public List<Control> controls{get;set;}
		public IChecker checker{get;set;}
		
		public ValidateContainer ()
		{
		}
		
		//public Func<ErrorProvider> conform()
		//{
			
		////	foreach(var con in controls)
		////	{checker.isConform(con.Text)}
			
		//}
		
	}
}

