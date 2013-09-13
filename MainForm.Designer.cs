/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2013/9/13
 * 时间: 15:06
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace BadAppleForWindowsForm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
        {
			this.pbxCanvas = new System.Windows.Forms.PictureBox();
			this.lblIntroduce = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxCanvas
			// 
			this.pbxCanvas.Location = new System.Drawing.Point(6, 6);
			this.pbxCanvas.Margin = new System.Windows.Forms.Padding(2);
			this.pbxCanvas.Name = "pbxCanvas";
			this.pbxCanvas.Size = new System.Drawing.Size(640, 723);
			this.pbxCanvas.TabIndex = 0;
			this.pbxCanvas.TabStop = false;
			// 
			// lblIntroduce
			// 
			this.lblIntroduce.AutoSize = true;
			this.lblIntroduce.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblIntroduce.Location = new System.Drawing.Point(674, 9);
			this.lblIntroduce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblIntroduce.MaximumSize = new System.Drawing.Size(345, 0);
			this.lblIntroduce.Name = "lblIntroduce";
			this.lblIntroduce.Size = new System.Drawing.Size(333, 224);
			this.lblIntroduce.TabIndex = 1;
			this.lblIntroduce.Text = "Bad Apple原曲旋律出自“東方”系列游戏第四作《東方幻想乡》，此曲因网上流传的PV黑白影绘动画而一炮走红，后续便有许多爱好者利用根据原视频创作出各种复刻版，" +
			"如扫雷版、TXT版、WORD版等等。本DEMO是思存工作室成员出于业余爱好制作的Winform版。";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1018, 740);
			this.Controls.Add(this.lblIntroduce);
			this.Controls.Add(this.pbxCanvas);
			this.Font = new System.Drawing.Font("新宋体", 12F);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.Name = "MainForm";
			this.Text = "BadApple";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbxCanvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
        }
		
		private System.Windows.Forms.PictureBox pbxCanvas;
        private System.Windows.Forms.Label lblIntroduce;
	}
}
