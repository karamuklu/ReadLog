
namespace LogOku
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnReadLog = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnSendExcel = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnReadLog
			// 
			this.btnReadLog.Location = new System.Drawing.Point(12, 12);
			this.btnReadLog.Name = "btnReadLog";
			this.btnReadLog.Size = new System.Drawing.Size(90, 44);
			this.btnReadLog.TabIndex = 1;
			this.btnReadLog.Text = "Read Log";
			this.btnReadLog.UseVisualStyleBackColor = true;
			this.btnReadLog.Click += new System.EventHandler(this.btnReadLog_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(240, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(139, 27);
			this.textBox1.TabIndex = 2;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(0, 110);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(1318, 644);
			this.listBox1.TabIndex = 3;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(385, 10);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(90, 44);
			this.btnFind.TabIndex = 3;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(1056, 21);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(250, 27);
			this.dtpDate.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(624, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Kayıt Sayısı :";
			// 
			// progressBar1
			// 
			this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar1.Location = new System.Drawing.Point(0, 95);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(1318, 15);
			this.progressBar1.TabIndex = 7;
			// 
			// btnSendExcel
			// 
			this.btnSendExcel.Location = new System.Drawing.Point(869, 18);
			this.btnSendExcel.Name = "btnSendExcel";
			this.btnSendExcel.Size = new System.Drawing.Size(111, 38);
			this.btnSendExcel.TabIndex = 8;
			this.btnSendExcel.Text = "Send To Excel";
			this.btnSendExcel.UseVisualStyleBackColor = true;
			this.btnSendExcel.Click += new System.EventHandler(this.btnSendExcel_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(627, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 39);
			this.button2.TabIndex = 9;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1318, 754);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnSendExcel);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnReadLog);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reading Log";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReadLog;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSendExcel;
		private System.Windows.Forms.Button button2;
	}
}

