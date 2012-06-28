using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace HachiValidater
{
	public class VTextbox : TextBox
	{
		#region"property"
		[Category("Validation")]
		[DefaultValue("")]
		[Description("エラー時に表示させるメッセージ文字列")]
		public string message { get; set; }

		[Category("Validation")]
		[DefaultValue(null)]
		[Description("検証ロジックを組み込んだコンポーネント")]
		public CheckConfigs.IChecker checker { get; set; }

		/// <summary>
		/// 検証に失敗した場合のフォーカスの遷移を許可するか否か.
		/// e.Cancel = 
		/// </summary>
		[Category("Validation")]
		[DefaultValue(true)]
		[Description("検証に失敗した場合のフォーカスの遷移を許可するか否か")]
		public bool isCanceled { get; set; }

		[Category("Validation")]
		[DefaultValue(null)]
		[Description("えらーぷろばいだー")]
		public ErrorProvider errorProvider { get; set; }
		#endregion

		/// <summary>
		/// constructor
		/// </summary>
		public VTextbox() : base()
		{
			base.Validating += new CancelEventHandler(validating);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		virtual protected void validating(Object sender, CancelEventArgs e)
		{
			if (checker == null) { return; }

			if (!checker.isConform(this.Text))
			{
				assertError();
				e.Cancel = isCanceled;
			}
			else
			{ removeErrorIcon(); }
		}

		private void assertError()
		{
			if (this.errorProvider != null)
			{
				errorProvider.SetError(this, message);
			}
		}

		private void removeErrorIcon()
		{
			if (this.errorProvider != null)
			{
				errorProvider.SetError(this, null);
			}
		}
	}
}
