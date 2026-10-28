/*
 * Creado por SharpDevelop.
 * Usuario: moren
 * Fecha: 27/10/2026
 * Hora: 08:13 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace op_bas
{
	partial class Form1
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
			this.txtvarA = new System.Windows.Forms.TextBox();
			this.txtvarB = new System.Windows.Forms.TextBox();
			this.txtvarC = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btncalcular = new System.Windows.Forms.Button();
			this.lblresx1 = new System.Windows.Forms.Label();
			this.lblresx2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtvarA
			// 
			this.txtvarA.Location = new System.Drawing.Point(144, 26);
			this.txtvarA.Name = "txtvarA";
			this.txtvarA.Size = new System.Drawing.Size(100, 20);
			this.txtvarA.TabIndex = 0;
			// 
			// txtvarB
			// 
			this.txtvarB.Location = new System.Drawing.Point(144, 58);
			this.txtvarB.Name = "txtvarB";
			this.txtvarB.Size = new System.Drawing.Size(100, 20);
			this.txtvarB.TabIndex = 1;
			// 
			// txtvarC
			// 
			this.txtvarC.Location = new System.Drawing.Point(144, 88);
			this.txtvarC.Name = "txtvarC";
			this.txtvarC.Size = new System.Drawing.Size(100, 20);
			this.txtvarC.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "variable A";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "variable B";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "variable C";
			// 
			// btncalcular
			// 
			this.btncalcular.Location = new System.Drawing.Point(69, 125);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(92, 47);
			this.btncalcular.TabIndex = 6;
			this.btncalcular.Text = "calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// lblresx1
			// 
			this.lblresx1.Location = new System.Drawing.Point(26, 188);
			this.lblresx1.Name = "lblresx1";
			this.lblresx1.Size = new System.Drawing.Size(205, 54);
			this.lblresx1.TabIndex = 7;
			// 
			// lblresx2
			// 
			this.lblresx2.Location = new System.Drawing.Point(26, 279);
			this.lblresx2.Name = "lblresx2";
			this.lblresx2.Size = new System.Drawing.Size(218, 45);
			this.lblresx2.TabIndex = 8;
			//this.lblresx2.Click += new System.EventHandler(this.Lblresx2Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 333);
			this.Controls.Add(this.lblresx2);
			this.Controls.Add(this.lblresx1);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtvarC);
			this.Controls.Add(this.txtvarB);
			this.Controls.Add(this.txtvarA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblresx2;
		private System.Windows.Forms.Label lblresx1;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtvarC;
		private System.Windows.Forms.TextBox txtvarB;
		private System.Windows.Forms.TextBox txtvarA;
	}
}
