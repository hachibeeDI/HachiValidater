using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;


namespace HachiValidater
{
	public class VButton<TControl>:Button
		where TControl:System.Windows.Forms.Control
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
		public List<CheckConfigs.ValidateContainer<TControl>> containeres { get; set; }

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

			List<TControl> contain; //avoid the cost that make instance in loop
			foreach (var con in containeres)
			{
				con.controls.ForEach(c => errorProvider.SetError(c, null)); //reset all error messages
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
