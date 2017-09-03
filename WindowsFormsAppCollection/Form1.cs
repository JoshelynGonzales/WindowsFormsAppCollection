using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCollection
{
	public partial class Form1 : Form
	{
		List<Producto> productos = new List<Producto>();
		Producto[] arrProductos = new Producto[7];
		int i = 0;

		Dictionary<string, Producto> dictProductos =
			new Dictionary<string, Producto>();


		public Form1()
		{
			InitializeComponent();
		}

		private void limpiar()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Producto p = new Producto(textBox1.Text,
				decimal.Parse(textBox2.Text), 
				int.Parse(textBox3.Text));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			foreach (Producto p in productos)
			{
				listBox1.Items.Add($"(p.Nombre),()");
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{


			limpiar();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			for (int j = 0; j < 1; j++)
			{
				Producto p = arrProductos[j];
				listBox1.Items.Add($"{p.Nombre},{p.Cantidad}, {p.Precio}, {j} / {i} +");
			}
			i = 0;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Producto p =new Producto(textBox1.Text,
				decimal.Parse(textBox2.Text), 
				int.Parse(textBox3.Text));
			dictProductos.Add(textBox1.Text, p);
			limpiar();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			foreach (KeyValuePair<string, Producto> entry in dictProductos)
			{
				Producto p = entry.Value;
				listBox1.Items.Add($"{p.Nombre},{p.Cantidad}, {p.Precio} ");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string searchkey = textBox4.Text;
			if (dictProductos.ContainsKey(searchkey))
			{
				Producto p = dictProductos[searchkey];
				MessageBox.Show($"{p.Nombre},{p.Cantidad}, {p.Precio}", "Ventas", MessageBoxButtons.OK);

			}
			else
			{
				MessageBox.Show("Producto no existe en el dictionary", "Ventas", MessageBoxButtons.OK);
			}
		
		}




		

	}
}
