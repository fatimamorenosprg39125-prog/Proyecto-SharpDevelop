/*
 * Creado por SharpDevelop.
 * Usuario: moren
 * Fecha: 27/10/2026
 * Hora: 07:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace op_bas
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
			this.txtnum1 = new System.Windows.Forms.TextBox();
			this.txynum2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnsuma = new System.Windows.Forms.Button();
			this.btnresta = new System.Windows.Forms.Button();
			this.btnmultiplicacion = new System.Windows.Forms.Button();
			this.btndivision = new System.Windows.Forms.Button();
			this.lblresultado = new System.Windows.Forms.Label();
			this.btnresiduo = new System.Windows.Forms.Button();
			this.btnformulageneral = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtnum1
			// 
			this.txtnum1.Location = new System.Drawing.Point(138, 12);
			this.txtnum1.Name = "txtnum1";
			this.txtnum1.Size = new System.Drawing.Size(100, 20);
			this.txtnum1.TabIndex = 0;
			// 
			// txynum2
			// 
			this.txynum2.Location = new System.Drawing.Point(138, 65);
			this.txynum2.Name = "txynum2";
			this.txynum2.Size = new System.Drawing.Size(100, 20);
			this.txynum2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "numero 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "numero 2";
			// 
			// btnsuma
			// 
			this.btnsuma.Location = new System.Drawing.Point(13, 101);
			this.btnsuma.Name = "btnsuma";
			this.btnsuma.Size = new System.Drawing.Size(87, 45);
			this.btnsuma.TabIndex = 4;
			this.btnsuma.Text = "suma";
			this.btnsuma.UseVisualStyleBackColor = true;
			this.btnsuma.Click += new System.EventHandler(this.BtnsumaClick);
			// 
			// btnresta
			// 
			this.btnresta.Location = new System.Drawing.Point(142, 101);
			this.btnresta.Name = "btnresta";
			this.btnresta.Size = new System.Drawing.Size(96, 45);
			this.btnresta.TabIndex = 5;
			this.btnresta.Text = "resta";
			this.btnresta.UseVisualStyleBackColor = true;
			this.btnresta.Click += new System.EventHandler(this.BtnrestaClick);
			// 
			// btnmultiplicacion
			// 
			this.btnmultiplicacion.Location = new System.Drawing.Point(13, 152);
			this.btnmultiplicacion.Name = "btnmultiplicacion";
			this.btnmultiplicacion.Size = new System.Drawing.Size(87, 44);
			this.btnmultiplicacion.TabIndex = 6;
			this.btnmultiplicacion.Text = "multiplicacion";
			this.btnmultiplicacion.UseVisualStyleBackColor = true;
			this.btnmultiplicacion.Click += new System.EventHandler(this.BtnmultiplicacionClick);
			// 
			// btndivision
			// 
			this.btndivision.Location = new System.Drawing.Point(142, 152);
			this.btndivision.Name = "btndivision";
			this.btndivision.Size = new System.Drawing.Size(96, 44);
			this.btndivision.TabIndex = 7;
			this.btndivision.Text = "divicion";
			this.btndivision.UseVisualStyleBackColor = true;
			this.btndivision.Click += new System.EventHandler(this.BtndivisionClick);
			// 
			// lblresultado
			// 
			this.lblresultado.Location = new System.Drawing.Point(28, 261);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(199, 39);
			this.lblresultado.TabIndex = 8;
			this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnresiduo
			// 
			this.btnresiduo.Location = new System.Drawing.Point(69, 202);
			this.btnresiduo.Name = "btnresiduo";
			this.btnresiduo.Size = new System.Drawing.Size(100, 48);
			this.btnresiduo.TabIndex = 9;
			this.btnresiduo.Text = "residuo";
			this.btnresiduo.UseVisualStyleBackColor = true;
			this.btnresiduo.Click += new System.EventHandler(this.BtnresiduoClick);
			// 
			// btnformulageneral
			// 
			this.btnformulageneral.Location = new System.Drawing.Point(59, 324);
			this.btnformulageneral.Name = "btnformulageneral";
			this.btnformulageneral.Size = new System.Drawing.Size(143, 44);
			this.btnformulageneral.TabIndex = 11;
			this.btnformulageneral.Text = "formula general";
			this.btnformulageneral.UseVisualStyleBackColor = true;
			this.btnformulageneral.Click += new System.EventHandler(this.BtnformulageneralClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 380);
			this.Controls.Add(this.btnformulageneral);
			this.Controls.Add(this.btnresiduo);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.btndivision);
			this.Controls.Add(this.btnmultiplicacion);
			this.Controls.Add(this.btnresta);
			this.Controls.Add(this.btnsuma);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txynum2);
			this.Controls.Add(this.txtnum1);
			this.Name = "MainForm";
			this.Text = "op bas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnformulageneral;
		private System.Windows.Forms.Button btnresiduo;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.Button btndivision;
		private System.Windows.Forms.Button btnmultiplicacion;
		private System.Windows.Forms.Button btnresta;
		private System.Windows.Forms.Button btnsuma;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txynum2;
		private System.Windows.Forms.TextBox txtnum1;
	}
}
