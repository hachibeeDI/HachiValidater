using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;


namespace HachiValidater
{
	public class VButton:Button
	{
		public VButton(): base()
		{
			base.Click += new System.EventHandler(Click);
		}

		#region"property"

		[Category("Validation")]
		[DefaultValue(null)]
		[Description("えらーぷろばいだー")]
		public ErrorProvider errorProvider { get; set; }

		/// <summary>
		/// 対象となるコントロールとチェッカーをもったコンテナリスト
		/// </summary>
		public List<CheckConfigs.ValidateContainer<Control>> containeres { get; set; }

		/// <summary>
		/// Validateを通った場合、Clickの次に呼ばれるイベント
		/// </summary>
		public event System.EventHandler afterComfirmed;
		#endregion

		/// <summary>
		/// 基底クラスのClickは隠す
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private new void Click(object sender, System.EventArgs e)
		{
			bool hasError = false;
			List<Control> contain;
			foreach (var con in containeres)
			{
				con.controls.ForEach(c => errorProvider.SetError(c, null)); //reset error messages
				contain = con.areConfirm();
				if (contain.Count != 0)
				{ 
					contain.ForEach(c => errorProvider.SetError(c, con.message));
					hasError = true;
				}
			}
			if (!hasError) { afterComfirmed(this, e); }
		}

	}
}
