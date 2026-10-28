/*
 * Creado por SharpDevelop.
 * Usuario: moren
 * Fecha: 27/10/2026
 * Hora: 08:13 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace op_bas
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			double a = double.Parse(txtvarA.Text);
			double b = double.Parse(txtvarB.Text);
			double c = double.Parse(txtvarC.Text);

			double discriminante = (b * b) - (4 * a * c);

			if (discriminante >= 0) {
			    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
			    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
			    lblresx1.Text = "x1 = " + x1;
			    lblresx2.Text = "x2 = " + x2;
			} else {
			    lblresx1.Text = "Raíces imaginarias";
			    lblresx2.Text = "";
			}

		}
		
	}
}
