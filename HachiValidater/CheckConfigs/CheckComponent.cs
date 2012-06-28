using System.ComponentModel;

namespace HachiValidater.CheckConfigs
{
	/// <summary>
	/// デザイナからコンポーネントとしてCheckerを使いたいならこちらを使う。
	/// コードだけで用いるならICheckerを実装したクラスを作るだけで十分
	/// </summary>
	public abstract class CheckComponent : Component, IChecker
	{
		#region"designer"
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}

		#endregion
		#endregion
		#region"Component's Interface"
		public CheckComponent()
		{
			InitializeComponent();
		}

		public CheckComponent(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
		#endregion

		public abstract bool isConform(string targ);

	}
}
