using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;


namespace HachiValidater
{
	class VButton:Button
	{
		public VButton(): base()
		{
			base.Click += new System.EventHandler(Click);
		}

		#region"property"
		/// <summary>
		/// 検査対象のコントロールとチェッカー
		/// </summary>
		public Dictionary<Control, CheckConfigs.IChecker> checkTargs { get; set; }

		/// <summary>
		/// 検査対象のコントロールと対応するメッセージ。
		/// TODO 上記と合わせたふたつはあとで抽象化
		/// </summary>
		public Dictionary<Control, string> massages { get; set; }


		[Category("Validation")]
		[DefaultValue(null)]
		[Description("えらーぷろばいだー")]
		public ErrorProvider errorProvider { get; set; }


		//TODO ジェネリックとかで汎用性を持たせたい
		public delegate void clickaction();
		#endregion

		/// <summary>
		/// 基底クラスのClickは隠す
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private new void Click(object sender, System.EventArgs e)
		{
			foreach (var con in getControls())
			{

			}
		}

		private IEnumerable<Control> getControls()
		{
			foreach (var con in checkTargs.Keys)
				yield return con;
		}
	}
}
