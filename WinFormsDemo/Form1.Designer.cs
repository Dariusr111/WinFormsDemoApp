﻿namespace WinFormsDemo
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(318, 321);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 68);
			this.button1.TabIndex = 0;
			this.button1.Text = "Importuoti į DB";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(217, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(222, 23);
			this.textBox1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(481, 96);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Pasirinkite Csv failą";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(217, 138);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(222, 23);
			this.textBox2.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(481, 138);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(137, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Pasirinkite DB";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(217, 183);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(222, 23);
			this.textBox3.TabIndex = 6;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(481, 183);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(137, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Sukurti naują DB";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(531, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "arba";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Cvs To DB";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private Button button2;
		private TextBox textBox2;
		private Button button3;
		private TextBox textBox3;
		private Button button4;
		private Label label1;
	}
}