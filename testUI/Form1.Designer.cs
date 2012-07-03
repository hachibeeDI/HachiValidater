namespace testUI
{
	partial class Form1
	{
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

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox1 = new HachiValidater.VTextbox();
			this.number1 = new HachiValidater.CheckConfigs.Number(this.components);
			this.button1 = new HachiValidater.VButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(116, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "数字のみ";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(70, 93);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(96, 19);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(70, 125);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(96, 19);
			this.textBox3.TabIndex = 4;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(70, 156);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(96, 19);
			this.textBox4.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.checker = this.number1;
			this.textBox1.errorProvider = this.errorProvider1;
			this.textBox1.isCanceled = false;
			this.textBox1.Location = new System.Drawing.Point(172, 12);
			this.textBox1.message = "数字じゃなきゃだめだよ";
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 19);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.containeres = null;
			this.button1.Location = new System.Drawing.Point(33, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.afterComfirmed += new System.EventHandler(this.button1_afterComfirmed);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "数字のみ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "数字のみ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "a-z";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 265);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ErrorProvider errorProvider1;
		private HachiValidater.VTextbox textBox1;
		private HachiValidater.CheckConfigs.Number number1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private HachiValidater.VButton button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;

	}
}

