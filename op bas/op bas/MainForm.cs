/*
 * Creado por SharpDevelop.
 * Usuario: moren
 * Fecha: 27/10/2026
 * Hora: 07:32 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace op_bas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnmultiplicacionClick(object sender, EventArgs e)
		{
			double num1 = double.Parse(txtnum1.Text);
			double num2 = double.Parse(txynum2.Text);
			double resultado = num1 * num2;
			lblresultado.Text = "Resultado: " + resultado;
		}
		
		void BtnsumaClick(object sender, EventArgs e)
		{
			double num1 = double.Parse(txtnum1.Text);
			double num2 = double.Parse(txynum2.Text);
			double resultado = num1 + num2;
			lblresultado.Text = "Resultado: " + resultado;

		}
		
		void BtnrestaClick(object sender, EventArgs e)
		{
			double num1 = double.Parse(txtnum1.Text);
			double num2 = double.Parse(txynum2.Text);
			double resultado = num1 - num2;
			lblresultado.Text = "Resultado: " + resultado;
		}
		
		void BtndivisionClick(object sender, EventArgs e)
		{
			double num1 = double.Parse(txtnum1.Text);
			double num2 = double.Parse(txynum2.Text);
			double resultado = num1 / num2;
			lblresultado.Text = "Resultado: " + resultado;
		}
		
		void BtnresiduoClick(object sender, EventArgs e)
		{
			double num1 = double.Parse(txtnum1.Text);
			double num2 = double.Parse(txynum2.Text);
			double resultado = num1 % num2; 
			lblresultado.Text = "Residuo: " + resultado;

		}
		
		void BtnformulageneralClick(object sender, EventArgs e)
		{
			Form1 formulario2 = new Form1();
			formulario2.Show();

		}
	}
}
