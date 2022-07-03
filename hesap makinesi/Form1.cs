using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		#region sayılar
		private void btn0_click(object sender, EventArgs e)
		{
			textBox1.Text += 0;
		}

		private void btn1_click(object sender, EventArgs e)
		{
			textBox1.Text += 1;
		}

		private void btn2_click(object sender, EventArgs e)
		{
			textBox1.Text += 2;
		}

		private void btn3_click(object sender, EventArgs e)
		{
			textBox1.Text += 3;
		}

		private void btn4_click(object sender, EventArgs e)
		{
			textBox1.Text += 4;
		}

		private void btn5_click(object sender, EventArgs e)
		{
			textBox1.Text += 5;
		}

		private void btn6_click(object sender, EventArgs e)
		{
			textBox1.Text += 6;
		}

		private void btn7_click(object sender, EventArgs e)
		{
			textBox1.Text += 7;
		}

		private void btn8_click(object sender, EventArgs e)
		{
			textBox1.Text += 8;
		}

		private void btn9_click(object sender, EventArgs e)
		{
			textBox1.Text += 9;
		}
		#endregion

		private void btnNokta_click(object sender, EventArgs e)
		{
			textBox1.Text += ",";
		}


		private void btnEşit_click(object sender, EventArgs e)//Önemli kısım
		{
			double sayı1 = 0, sayı2 = 0, sayı3 = 0;
			string sayı11 = null, sayı22 = null, sayı33 = null;
			textBox1.Text += "=";
			int sayaç = 0;
			double sonuç2;
			string[] aa = new string[textBox1.Text.Length];
			for (int ü = 0; ü < textBox1.Text.Length; ü++)//0(5),1(+),2(6),3(=)
			{
				aa[ü] = Convert.ToString(textBox1.Text[ü]);
			}
			for (int i = 0; i < textBox1.Text.Length; i++)
			{
				if (aa[i] == "+" || aa[i] == "-" || aa[i] == "*" || aa[i] == "÷")
				{
					for (int l = sayaç + 1; l < textBox1.Text.Length; l++)//sayı 2 işlemleri
					{
						if (aa[l] != "=")
						{ sayı22 += aa[l]; }

						else
						{
							for (int u = sayaç; u < textBox1.Text.Length; u++)
							{
								sayı1 = Convert.ToDouble(sayı11);
								sayı2 = Convert.ToDouble(sayı22);
								if (aa[u] == "+")
								{ sonuç2 = sayı1 + sayı2; textBox1.Text = Convert.ToString(sonuç2); return; }
								if (aa[u] == "-")//Çıkar
								{ sonuç2 = sayı1 - sayı2; textBox1.Text = Convert.ToString(sonuç2); return; }
								if (aa[u] == "*")//Çarp
								{ sonuç2 = sayı1 * sayı2; textBox1.Text = Convert.ToString(sonuç2); return; }
								if (aa[u] == "÷")//Böl
								{ sonuç2 = sayı1 / sayı2; textBox1.Text = Convert.ToString(sonuç2); return; }}}}}
				else { sayı11 += aa[i]; }
				sayaç += 1;
			}
		}
		private void btnEksi_click(object sender, EventArgs e)
		{
			textBox1.Text += "-";
		}

		private void btnArtı_click(object sender, EventArgs e)
		{
			textBox1.Text += "+";
		}

		private void btnBölü_click(object sender, EventArgs e)
		{
			textBox1.Text += "÷";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnÇarpı_click(object sender, EventArgs e)
		{
			textBox1.Text += "*";
		}

		private void button11_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}
	}
}

