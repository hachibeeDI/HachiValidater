using System;
using System.Collections.Generic;
using System.ComponentModel;
using HachiValidater.CheckConfigs;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testUI
{
	public partial class Form1 : Form
	{

		private HachiValidater.CheckConfigs.ValidateContainer container1;
		private HachiValidater.CheckConfigs.ValidateContainer container2;


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.isCanceled = true;
			container1 = 
				new HachiValidater.CheckConfigs.ValidateContainer(new Omni(@"^\d+$"),"数字オンリー");
			container2 = 
				new HachiValidater.CheckConfigs.ValidateContainer(new Omni(@"^[a-z]+$"),"a～zだけ");
			container1.controls = new List<Control> { textBox2, textBox3 };
			container2.controls = new List<Control> { textBox4 };
			button1.containeres = new List<ValidateContainer> { container1, container2 };
			button1.errorProvider = errorProvider1;
		}

		private void button1_afterComfirmed(object sender, EventArgs e)
		{
			MessageBox.Show("せい！");
		}
	}
}
