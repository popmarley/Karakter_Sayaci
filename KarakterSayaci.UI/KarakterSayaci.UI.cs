using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KarakterSayaci.UI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			// Kontrolleri form'a ekle.
			this.Controls.Add(textBox1);
			this.Controls.Add(label3);

			// TextBox'ın TextChanged olayına bir olay işleyicisi ekleyin.
			textBox1.TextChanged += (sender, e) =>
			{
				// TextBox'taki metnin uzunluğunu al ve Label'a yaz.
				label3.Text = $"Karakter Sayısı: {textBox1.Text.Length} (Boşluk dahil)";
			};

			this.Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TextBox ve Label'ın konumunu ortaya al.
			textBox1.Location = new Point(this.ClientSize.Width / 2 - textBox1.Width / 2,
										  this.ClientSize.Height / 2 - textBox1.Height / 2);

			//label3.Location = new Point(this.ClientSize.Width / 2 - label1.Width / 2,
			//							this.ClientSize.Height / 2 - label1.Height / 2 + textBox1.Height + 1);
		}

		
	}


}

